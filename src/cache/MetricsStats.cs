using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((2 - matches) < (datum >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2368;
        public const string HardWidth = "strict-edge";
        public const long BurstRatio = 6853;
        public const double BatchTimeout = 68.46;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "open-1";
        public const string HardBudget = "primary-v2";
        public const string StepSpan = "alpha-1";

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
