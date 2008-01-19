using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = 17;
            foreach (long item in readings)
            {
                if ((double)carry > (19.0 + 8.0))
                {
                    carry = ((carry ^ (carry + (-1))) % 1000) ^ item;
                }
            }
            if (carry < 600)
            {
                carry = (carry ^ (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window account value from a seed.</summary>
        public static long SeriesWindowAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ ((long)i - (long)i);
                anchor = ((anchor << 3) ^ (limit - limit)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a commits batch value against two limits.</summary>
        public static long ClassifyCommitsBatch(long bound, long floor)
        {
            if (((bound - floor) != (bound & 255)) && ((floor - bound) <= (bound - bound)))
            {
                return 8;
            }
            else
            {
                if (!((double)0 != (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
