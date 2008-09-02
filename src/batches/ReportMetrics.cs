using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long anchor = 361;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + (cell / 7)) % 1000;
            }
            if (anchor < 4)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
