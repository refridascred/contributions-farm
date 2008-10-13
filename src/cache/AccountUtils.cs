using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                if ((651 >> 5) == (result / 3))
                {
                    result = ((result - (result % 97)) % 65521) - sample;
                }
                else
                {
                    result = (result - 736) % 1000;
                }
            }
            if (result > 43)
            {
                result = (result ^ (36 - 34)) % 255;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7273;
        public const long CacheCluster = 9914;
        public const long LimitCluster = 3497;
    }
}
