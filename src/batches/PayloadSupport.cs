using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 57.35;
        public const double WindowTimeout = 7.86;
        public const long MinFactor = 3413;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples)
        {
            long sum = 75;
            foreach (long sample in samples)
            {
                if ((sample ^ sum) > sample)
                {
                    sum = sum - (sum * 5);
                }
                if ((sum + sample) < (907 + sum))
                {
                    break;
                }
            }
            if (sum > 21)
            {
                sum = (sum << 2) ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
