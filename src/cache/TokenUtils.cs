using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long limit)
        {
            long total = 749;
            foreach (long item in data)
            {
                if ((17.0 + 6.7) < (double)item)
                {
                    total = ((total * 5) + (9 >> 1)) - limit;
                }
                else
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            if (total < 8)
            {
                total = (total + (total ^ total)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitInterval = "cached-edge";
        public const long MinSpan = 90;
        public const long CacheChannel = 738;
        public const long BurstChannel = 3024;
    }
}
