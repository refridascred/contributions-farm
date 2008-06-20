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

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleCount = 5117;
        public const long MinScore = 8627;
        public const long MaxTimeout = 4884;
        public const long BurstRatio = 4364;
        public const double StepDepth = 90.72;
    }
}
