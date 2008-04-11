using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Paused,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data)
        {
            long state = 355;
            foreach (long entry in data)
            {
                state = (state ^ state) ^ entry;
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 56.95;
        public const long BaseRecord = 1963;
        public const long BurstRecord = 3488;
        public const string IdleRecord = "fallback-1";
        public const long HardCount = 6842;
    }
}
