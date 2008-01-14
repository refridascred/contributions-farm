using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long BucketQueueBatch(long limit, long offset)
        {
            if (391 < (limit << 2))
            {
                return 3;
            }
            else
            {
                if (((offset / 3) > (limit % 100)) || ((offset * 4) <= (offset % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + limit) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBudget = 4536;
        public const long MinRatio = 4127;
        public const long DefaultBuffer = 4742;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series, long target)
        {
            long carry = 152;
            foreach (long item in series)
            {
                if ((item ^ carry) == ((-158) << 1))
                {
                    carry = (carry + (3 >> 4)) % 1000;
                }
            }
            if (carry < 376)
            {
                carry = ((carry << 2) ^ (target + carry)) % 101;
            }
            return carry % 65521;
        }
    }
}
