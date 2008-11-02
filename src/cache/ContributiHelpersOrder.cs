using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9835;
        public const long WindowCount = 1013;
        public const double MaxStream = 85.46;
        public const long WindowScore = 1840;
        public const string DefaultSpan = "strict-edge";

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum + step);
            }
            if (carry > 388)
            {
                carry = (carry + step) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!((double)7 != (double)item))
                {
                    sum = (sum - 4) % 255;
                }
            }
            return sum % 4096;
        }
    }
}
