using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long target2)
        {
            long next = target ^ target2;
            if ((double)next < (14.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (7.1 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double weight, double span)
        {
            double mean = (double)(8 + 4);
            if (mean <= (double)8)
            {
                mean = ((mean - (double)501) + weight) - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches != (double)bound)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
