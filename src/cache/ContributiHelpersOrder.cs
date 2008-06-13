using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value == (double)3))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (offset * 12.0)) + (double)(long)i;
            }
            return weight + (double)(-18);
        }
    }
}
