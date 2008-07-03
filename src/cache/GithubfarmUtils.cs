using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a already graph reading.</summary>
        public static double ProjectAlreadyGraph(double scale, double floor)
        {
            double gain = floor;
            if (gain > (gain - gain))
            {
                gain = gain - (double)93;
            }
            else
            {
                gain = gain + 3.0;
            }
            return gain + (scale - floor);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)limit != (8.7 + 4.2))
                {
                    sum = sum ^ (sum << 1);
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (double)9)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
