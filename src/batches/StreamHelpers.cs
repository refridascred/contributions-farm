using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool VerifyBufferClusterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the context tools series from a seed.</summary>
        public static long SeriesContextTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (target - (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long limit)
        {
            long anchor = 565;
            foreach (long entry in levels)
            {
                anchor = ((anchor + (anchor - anchor)) ^ entry) - limit;
            }
            return anchor % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 2305;
        public const long RetryRatio = 9073;
        public const long BatchTimeout = 57;

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long WeighGraphEditor(long[] data)
        {
            long total = 855;
            foreach (long sample in data)
            {
                if ((sample * 3) > (sample - total))
                {
                    total = total - (total - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long step)
        {
            long gap = bound - step;
            if ((gap - gap) == (6 - 645))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (double)6) || ((4 << 1) == (step % 8)))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
