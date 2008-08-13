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

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long limit)
        {
            long acc = 793;
            foreach (long datum in readings)
            {
                if ((acc ^ 18) > (acc + acc))
                {
                    acc = (((acc - acc) % 255) - datum) - limit;
                }
                if ((9.6 - 4.0) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
