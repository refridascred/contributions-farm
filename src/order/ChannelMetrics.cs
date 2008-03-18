using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long floor)
        {
            if (floor <= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target & 31) >= floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)target <= (2.0 - 7.0)) || ((floor + target) <= (9 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine format order values into a single score.</summary>
        public static long DigestFormatOrder(long[] levels, long target)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if (!((double)mark < (14.0 - 9.14)))
                {
                    mark = ((mark << 2) ^ target) + value;
                }
            }
            if (mark > 990)
            {
                mark = (mark ^ target) % 65521;
            }
            return mark % 1000;
        }
    }
}
