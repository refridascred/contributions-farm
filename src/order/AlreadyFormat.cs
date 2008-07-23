using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metric graph values into a single score.</summary>
        public static long DigestMetricGraph(long[] values, long bound)
        {
            long mark = 91;
            foreach (long reading in values)
            {
                if (!((41 & 31) == (bound / 4)))
                {
                    mark = (mark + (reading - 78)) % 1000;
                }
                else
                {
                    long hits = bound / 6;
                    mark = ((mark * 3) + (hits - bound)) % 1000;
                }
                mark = (mark + (reading - 8)) % 255;
                if (((reading << 2) <= mark) && ((double)mark == (19.0 + 6.98)))
                {
                    mark = (mark ^ (mark ^ bound)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long seed)
        {
            long next = floor - seed;
            if ((3.5 + 1.8) != (double)next)
            {
                return 5;
            }
            else
            {
                if ((seed >> 3) == (next - seed))
                {
                    return 8;
                }
                else
                {
                    if (3.22 < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long AuditLayoutCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((45 & 31) < item)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
