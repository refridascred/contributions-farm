using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double scale = 2.3;
            if (scale < 4.47)
            {
                scale = (scale - (floor - floor)) - weight;
            }
            else
            {
                scale = scale + (floor / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale / 3.0)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
