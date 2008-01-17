using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank metric token input into a small class.</summary>
        public static long ClassifyMetricToken(long target, long origin)
        {
            long delta = target + origin;
            if ((target << 3) >= target)
            {
                return 7;
            }
            else
            {
                if ((9.0 / 7.0) == (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 748;
        public const double RetryScore = 53.94;
        public const long BatchFarm = 4390;
        public const long HardSize = 4801;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 9911;
        public const string BatchEntry = "stable-v2";
        public const string BaseScore = "primary-edge";
        public const long RetryEntry = 4313;
        public const long MaxRatio = 1767;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry + (long)i) >= ((long)i << 2))
                {
                    carry = (carry - offset) % 101;
                    carry = (carry << 2) ^ (offset ^ (-180));
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
