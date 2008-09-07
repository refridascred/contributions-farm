using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long carry = 82;
            foreach (long item in series)
            {
                if ((9.6 / 5.0) != (double)item)
                {
                    carry = ((carry * 4) + seed) % 1000;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 4)
            {
                carry = ((carry * 5) + seed) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 5242;
        public const long CacheFactor = 2986;
        public const long RetryLevel = 6109;
        public const long BaseTimeout = 285;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long floor)
        {
            long carry = 40;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    carry = carry + 84;
                }
            }
            if (carry > 3)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((double)step >= (9.01 - 4.34))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= (6 - (-85)))
                {
                    return 5;
                }
                else
                {
                    if (1 <= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
