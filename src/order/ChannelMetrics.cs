using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long floor)
        {
            long sum = 60;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (item % 2)) % 4096;
            }
            if (sum < 6)
            {
                sum = sum - floor;
            }
            return sum;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinInterval = 6952;
        public const long BurstSize = 4964;
        public const long CacheTimeout = 6820;
    }
}
