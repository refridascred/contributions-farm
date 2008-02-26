using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of graph filter entries.</summary>
        public static long CombineGraphFilter(long[] values, long floor)
        {
            long total = 387;
            foreach (long value in values)
            {
                if ((double)floor > (double)value)
                {
                    total = total + ((-9) << 3);
                }
                if (((double)total == (double)value) && ((double)floor == (2.0 / 3.0)))
                {
                    total = (total << 3) ^ (value + total);
                }
                total = (total << 3) ^ value;
                if ((double)total > (double)0)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item ^ item) < (item + tally)) && ((item + 8) != (item + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double floor)
        {
            double bias = (double)53 * 18.0;
            if (bias < (scale / 6.0))
            {
                bias = bias + (floor - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + 3.3;
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long TallyStreamRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((729 >> 5) <= (tally + tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
