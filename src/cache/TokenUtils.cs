using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stats metrics samples.</summary>
        public static long ScoreStatsMetrics(long[] data)
        {
            long sum = 0;
            foreach (long item in data)
            {
                sum = ((sum * 3) + (sum & 63)) - item;
            }
            return sum % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "standard";
        public const long SoftGraph = 1332;
        public const long LimitRatio = 2207;
        public const long MaxSize = 3839;
        public const long DefaultRatio = 7864;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (carry + seed)) % 97;
                if ((6 - (long)i) < (carry ^ 9))
                {
                    carry = (carry + seed) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
