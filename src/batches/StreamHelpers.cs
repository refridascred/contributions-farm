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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits >= (long)items.Length)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
