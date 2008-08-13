using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 9116;
        public const long HardProfile = 2045;
        public const string BurstBudget = "legacy-v2";
        public const long StepProfile = 6229;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long ClassifyLayoutCommand(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if (((seed2 / 6) != (seed2 + seed2)) || ((step - seed2) == (seed & 63)))
            {
                return 4;
            }
            else
            {
                if (!(step <= (154 - seed)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
