using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a record route sample.</summary>
        public static long LookupRecordRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
