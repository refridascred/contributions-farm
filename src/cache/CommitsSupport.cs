using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Queued,
            Retry,
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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            long span = origin ^ floor;
            if (!(origin <= span))
            {
                return 4;
            }
            else
            {
                if (((932 & 1) == (origin + span)) || ((origin >> 3) >= (4 % 2)))
                {
                    return 1;
                }
                else
                {
                    if ((9.4 + 6.9) >= (double)span)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
