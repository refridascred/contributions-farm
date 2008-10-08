using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 6602;
        public const double StepMetric = 1.19;
        public const long CacheSize = 1950;
        public const long IdleMetric = 7505;
        public const double HardLevel = 30.44;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
