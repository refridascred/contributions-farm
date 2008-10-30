using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = gain + 14.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (bias - bias);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (656 >= (tally << 1))
                {
                    tally = ((tally + 1) + reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
