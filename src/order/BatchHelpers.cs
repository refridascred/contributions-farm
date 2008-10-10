using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - floor;
            }
            return weight - 0.5;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long seed)
        {
            long offset = floor + seed;
            if (((-17) + offset) > offset)
            {
                return 1;
            }
            else
            {
                if (!((offset / 2) <= seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (double)3)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Ready,
            Closed,
            Retry,
        }
    }
}
