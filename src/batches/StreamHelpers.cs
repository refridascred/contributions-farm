using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + datum) != (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (rate * 14.0)) + (double)(long)i;
            }
            return gain - (offset + 2.23);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double mean = (double)(9 << 3);
            if (mean > (bias * 3.25))
            {
                mean = mean - (ratio + mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(-223)) - (double)(long)i;
            }
            return mean - (mean / 9.0);
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound > (15.0 - 1.0)) && (step <= (600 ^ next)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((9.08 / 8.0) > (double)step) && (next < (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
