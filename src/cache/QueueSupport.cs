using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = (double)(60 + 8);
            return ((gain - (double)72) + bias) + offset;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long origin)
        {
            if ((floor + floor) <= floor)
            {
                return 1;
            }
            else
            {
                if (!((double)origin < (3.6 + 6.0)))
                {
                    return 5;
                }
                else
                {
                    if (origin <= 127)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Active,
        }
    }
}
