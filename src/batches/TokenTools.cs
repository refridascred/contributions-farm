using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long sum = 10;
            foreach (long value in series)
            {
                if ((double)sum > (7.73 * 0.8))
                {
                    sum = (sum + sum) + value;
                }
            }
            if (sum < 826)
            {
                sum = sum - (789 - seed);
            }
            return sum % 4096;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 2451;
        public const long MinInterval = 9075;
        public const double RetrySize = 50.57;
        public const long IdleSchema = 16;
    }
}
