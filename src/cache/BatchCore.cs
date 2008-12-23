using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (carry ^ (long)i);
                carry = carry - ((long)i % 5);
                if ((6 + carry) > ((long)i & 127))
                {
                    carry = carry ^ (450 >> 1);
                }
                else
                {
                    carry = (carry + ((long)i + 892)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long RollOrderContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((5.57 - 14.0) > (double)sum))
                {
                    sum = (sum + (long)i) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Queued,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2623;
        public const double LimitCount = 81.17;
        public const double RetryFactor = 81.72;
        public const double DefaultInterval = 36.04;
        public const long SoftBuffer = 5763;
    }
}
