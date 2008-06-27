using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                mix = (mix + (26 % 100)) ^ entry;
            }
            return mix;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long limit)
        {
            if (9.42 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (7.4 > (double)target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
