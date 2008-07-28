using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSize = 4373;
        public const long BurstBudget = 2374;
        public const double RetryInterval = 29.96;
        public const double StepDepth = 66.81;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 6) > (bound / 8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long offset)
        {
            long gap = seed + offset;
            if ((offset * 4) <= offset)
            {
                return 6;
            }
            else
            {
                if (gap <= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)gap >= (6.52 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + 0) < (gap + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
