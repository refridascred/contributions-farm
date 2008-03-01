using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up stats schema samples.</summary>
        public static long MatchStatsSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
