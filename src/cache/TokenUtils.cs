using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary-edge";
        public const long MaxRatio = 4436;
        public const long MaxInterval = 2994;
        public const long DefaultWindow = 8873;
        public const long SoftWindow = 1915;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((double)limit < (7.87 + 2.3)) || ((bound << 2) > bound))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 20.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= 1.0) && ((bound + bound) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series)
        {
            long carry = 873;
            foreach (long reading in series)
            {
                if ((reading + reading) < carry)
                {
                    carry = (carry + carry) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 255;
                }
            }
            return carry;
        }
    }
}
