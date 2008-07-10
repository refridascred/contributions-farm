using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 9175;
        public const string BatchCache = "alpha-edge";
        public const long HardLevel = 7532;
        public const string MaxCache = "primary-v2";
        public const string MinInterval = "strict-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "standard";
        public const long DefaultBudget = 611;
        public const long LimitChannel = 1752;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((38 + count) != (cell % 12)) || ((double)count != (10.0 + 17.0)))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
