using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
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

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double gain = 4.53 / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain + 4.0)) + (double)(long)i) - bias2;
            }
            return gain - bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.4 - 6.4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
