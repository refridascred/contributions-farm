using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long offset)
        {
            long next = bound ^ offset;
            if (offset >= (-586))
            {
                return 7;
            }
            else
            {
                if ((next + offset) >= (offset * 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-v2";
        public const double IdleFilter = 24.88;
        public const double BurstInterval = 23.33;
        public const long WindowFilter = 1311;
        public const long HardFilter = 7204;
    }
}
