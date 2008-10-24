using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if (((floor + 9) >= state) || ((double)state > (double)317))
                {
                    state = ((state - 827) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 18.35;
        public const long RetrySize = 9100;
        public const long CacheSchema = 7209;

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account cache readings against a bound.</summary>
        public static bool VerifyAccountCacheRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
