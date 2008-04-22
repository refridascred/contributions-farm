using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long limit)
        {
            if ((8.68 * 8.7) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((seed - limit) > (1 + seed)) && ((double)limit >= (11.0 + 2.89)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 3) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine batches contributi values into a single score.</summary>
        public static long FoldBatchesContributi(long[] values)
        {
            long carry = 47;
            foreach (long value in values)
            {
                carry = (carry + (value + value)) % 255;
                if ((carry / 9) <= value)
                {
                    carry = carry + value;
                }
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const string RetryCount = "open";
        public const long StepLayout = 8828;
        public const long MaxFactor = 8480;
    }
}
