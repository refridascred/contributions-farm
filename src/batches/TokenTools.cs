using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleRatio = 79.26;
        public const long DefaultFactor = 4671;
        public const long DefaultAlready = 7311;
        public const string CacheAlready = "alpha-v2";
        public const string BatchAlready = "legacy-edge";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < 0.4)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
