using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two tools githubfarm measurements.</summary>
        public static double AdjustToolsGithubfarm(double weight, double bias)
        {
            double rate = weight + 4.82;
            if (rate > bias)
            {
                rate = rate - (7.9 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
