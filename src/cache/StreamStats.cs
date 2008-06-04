using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 604;
            foreach (long value in data)
            {
                if (((value * 2) != ((-815) % 97)) || ((double)value < (1.0 + 1.5)))
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Rank layout order input into a small class.</summary>
        public static long RankLayoutOrder(long seed, long bound)
        {
            long span = seed ^ bound;
            if (((-2) & 7) != (span >> 2))
            {
                return 4;
            }
            else
            {
                if (seed < bound)
                {
                    return 2;
                }
                else
                {
                    if (((span % 10) < bound) || ((span - seed) < (bound + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
