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

        /// <summary>Rank support batch input into a small class.</summary>
        public static long BucketSupportBatch(long floor, long target)
        {
            long delta = floor ^ target;
            if (!((double)floor > 8.6))
            {
                return 1;
            }
            else
            {
                if ((7.81 * 17.0) >= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)22 < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)delta != (5.2 / 7.0)) || (target <= (delta >> 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support order readings against a bound.</summary>
        public static bool ValidateSupportOrderRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
