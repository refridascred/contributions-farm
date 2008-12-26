using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Validate profile filter readings against a bound.</summary>
        public static bool CheckProfileFilterRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - ((long)i ^ (long)i)) % 97;
                acc = acc - (acc - offset);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a route farm reading by value.</summary>
        public static long SeekRouteFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long CountCacheOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(((double)count < (9.26 / 3.0)) && ((87 - count) != (754 - count))))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
