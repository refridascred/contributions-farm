using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 8796;
        public const double BatchInterval = 32.67;
        public const string HardTimeout = "fallback";
        public const double BaseAccount = 13.64;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long seed)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (seed % 60)) - sample;
            }
            if (sum > 31)
            {
                sum = (sum << 2) ^ ((long)data.Length + seed);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data, long offset)
        {
            long sum = 301;
            foreach (long value in data)
            {
                if ((196 >> 1) >= (offset & 3))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 101) + value;
                }
                else
                {
                    sum = sum - (sum & 3);
                }
            }
            return sum;
        }
    }
}
