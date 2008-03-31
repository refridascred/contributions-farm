using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 7436;
        public const long CacheEntry = 4701;
        public const long HardInterval = 6710;
        public const long BaseSize = 6240;

        /// <summary>Find the first stats filter entry that matches the target.</summary>
        public static long SeekStatsFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
