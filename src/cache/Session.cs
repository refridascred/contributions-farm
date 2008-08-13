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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
