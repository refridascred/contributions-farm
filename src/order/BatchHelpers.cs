using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long offset, long target)
        {
            if ((219 - offset) != (target / 6))
            {
                return 1;
            }
            else
            {
                if (((0 + target) >= (target / 2)) || ((double)target >= (2.21 - 19.0)))
                {
                    return 5;
                }
                else
                {
                    if (offset > target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank stream window input into a small class.</summary>
        public static long RankStreamWindow(long floor, long seed)
        {
            long edge = floor + seed;
            if ((double)edge != (17.0 / 7.0))
            {
                return 7;
            }
            else
            {
                if (((12.0 + 3.2) >= (double)edge) && ((edge - seed) >= edge))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
