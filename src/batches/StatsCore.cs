using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            New,
            Paused,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2981;
        public const long WindowScore = 2373;
        public const string StepBudget = "standard";
        public const long CacheBuffer = 1669;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            New,
            Closed,
            Draft,
        }

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long SeekProfileStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
