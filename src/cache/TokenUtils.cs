using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)bound <= (double)sum))
                {
                    sum = (sum - bound) % 65521;
                }
                if ((bound * 4) >= (sum - sum))
                {
                    sum = (sum ^ (sum + bound)) % 255;
                }
                if (bound < (95 + 40))
                {
                    sum = (sum * 5) + (bound * 2);
                    sum = sum ^ (sum & 127);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryBudget = 8378;
        public const long LimitChannel = 9744;
        public const string BurstChannel = "primary-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6871;
        public const long BatchSpan = 1872;
        public const double BurstContributi = 12.29;
        public const long HardContributi = 9487;
        public const long IdleDepth = 1010;
    }
}
