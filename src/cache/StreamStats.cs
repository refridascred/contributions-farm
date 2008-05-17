using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph batches reading.</summary>
        public static double BlendGraphBatches(double bias, double span)
        {
            double gain = 8.9;
            return (gain - (gain - span)) + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3960;
        public const string MaxScore = "standard-edge";
        public const long BatchInterval = 2313;
        public const string SoftGithubfarm = "cached-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (1.0 * 11.0))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long limit)
        {
            if ((floor << 2) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) != (limit ^ 23))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (1 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
