Public Class Form1
    Dim check As Boolean = False
    Dim score As Integer = 0


    Private Sub buttonFalse()
        A1.Enabled = False
        A2.Enabled = False
        A3.Enabled = False
        A4.Enabled = False
        A5.Enabled = False
        A6.Enabled = False
        A7.Enabled = False
        A8.Enabled = False
        A9.Enabled = False
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click

    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click

    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click

    End Sub

    Private Sub A9_Click(sender As Object, e As EventArgs) Handles A9.Click

    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click

    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click

    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click

    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click

    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        A1.Enabled = True
        A2.Enabled = True
        A3.Enabled = True
        A4.Enabled = True
        A5.Enabled = True
        A6.Enabled = True
        A7.Enabled = True
        A8.Enabled = True
        A9.Enabled = True

        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        A4.Text = ""
        A5.Text = ""
        A6.Text = ""
        A7.Text = ""
        A8.Text = ""
        A9.Text = ""

        A1.BackColor = Color.PeachPuff
        A2.BackColor = Color.PeachPuff
        A3.BackColor = Color.PeachPuff
        A4.BackColor = Color.PeachPuff
        A5.BackColor = Color.PeachPuff
        A6.BackColor = Color.PeachPuff
        A7.BackColor = Color.PeachPuff
        A8.BackColor = Color.PeachPuff
        A9.BackColor = Color.PeachPuff
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        A1.Enabled = True
        A2.Enabled = True
        A3.Enabled = True
        A4.Enabled = True
        A5.Enabled = True
        A6.Enabled = True
        A7.Enabled = True
        A8.Enabled = True
        A9.Enabled = True

        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        A4.Text = ""
        A5.Text = ""
        A6.Text = ""
        A7.Text = ""
        A8.Text = ""
        A9.Text = ""

        A1.BackColor = Color.Peru
        A2.BackColor = Color.Peru
        A3.BackColor = Color.Peru
        A4.BackColor = Color.Peru
        A5.BackColor = Color.Peru
        A6.BackColor = Color.Peru
        A7.BackColor = Color.Peru
        A8.BackColor = Color.Peru
        A9.BackColor = Color.Peru


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
