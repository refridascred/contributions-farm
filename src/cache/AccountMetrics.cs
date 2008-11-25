using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] samples)
        {
            long anchor = 90;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ ((-9) << 1)) % 4096) + value;
            }
            if (anchor < 56)
            {
                anchor = ((anchor << 3) ^ 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultDepth = 22.17;
        public const long BaseBatches = 1550;
        public const long RetryBatches = 5504;
        public const long LimitBatches = 3246;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading >= (reading * 4))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (!((4.0 / 3.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (seed * 4))
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (seed >> 3)) || ((seed - seed) <= (557 & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - seed) > (seed + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session account values into a single score.</summary>
        public static long FoldSessionAccount(long[] samples, long step)
        {
            long result = 67;
            foreach (long item in samples)
            {
                result = result ^ (step ^ item);
            }
            if (result < 8)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
