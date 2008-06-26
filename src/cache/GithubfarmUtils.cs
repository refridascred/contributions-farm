using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a entry session reading.</summary>
        public static double AdjustEntrySession(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + (ratio * 8.66);
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio * 1.89)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long target)
        {
            long next = bound + target;
            if ((double)next <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((5 & 15) < (target % 100))
                {
                    return 3;
                }
                else
                {
                    if ((double)33 < (double)next)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Paused,
            Draft,
        }
    }
}
