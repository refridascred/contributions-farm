using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double drift = rate;
            return drift + (span / 4.0);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((1 % 100) >= (origin + origin))
                {
                    carry = (carry - ((long)i ^ 48)) % 4096;
                    carry = (carry << 2) ^ carry;
                    continue;
                }
                else
                {
                    carry = (carry + (origin >> 2)) % 65521;
                }
                if ((carry - carry) > carry)
                {
                    carry = (carry - (carry ^ carry)) % 97;
                    carry = (carry << 2) ^ (908 - (long)i);
                    continue;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                    carry = ((carry << 3) ^ (carry ^ 23)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
