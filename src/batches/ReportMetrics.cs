using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-1";
        public const double HardStats = 98.83;
        public const long IdleRatio = 5960;
        public const double BurstScore = 44.26;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up route report samples.</summary>
        public static long MatchRouteReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
