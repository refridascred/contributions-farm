using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6693;
        public const long RetryScore = 7252;
        public const double HardScore = 31.97;
        public const string SoftContributi = "local-edge";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support token samples.</summary>
        public static long WeighSupportToken(long[] data, long target)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                if (reading >= (sum ^ target))
                {
                    sum = (sum * 5) + (sum ^ target);
                    sum = (sum - (reading - target)) % 255;
                }
                else
                {
                    sum = sum - (2 & 63);
                }
                sum = (sum ^ (sum + 81)) % 1000;
                sum = (sum * 3) + reading;
            }
            if (sum > 35)
            {
                sum = (sum << 3) ^ (target ^ target);
            }
            return sum;
        }
    }
}
