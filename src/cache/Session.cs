using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 5811;
        public const long BaseDepth = 9346;
        public const long IdleSpan = 7113;
        public const string BatchTimeout = "strict-1";

        /// <summary>Combine commits farm values into a single score.</summary>
        public static long ScoreCommitsFarm(long[] series, long limit)
        {
            long anchor = -41;
            foreach (long entry in series)
            {
                long bound = (limit + 276) >> 5;
                if ((658 / 8) >= entry)
                {
                    anchor = anchor + (bound ^ entry);
                }
                else
                {
                    anchor = anchor - (entry * 3);
                    bound = bound + (832 / 4);
                }
                anchor = (anchor ^ (entry + limit)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleCount = 5117;
        public const long MinScore = 8627;
        public const long MaxTimeout = 4884;
        public const long BurstRatio = 4364;
        public const double StepDepth = 90.72;
    }
}
