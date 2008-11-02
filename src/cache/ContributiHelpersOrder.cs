using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                result = (result - (datum + result)) % 255;
                result = result - (631 - datum);
                if (9 <= (result * 4))
                {
                    break;
                }
            }
            return result % 1000;
        }

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
