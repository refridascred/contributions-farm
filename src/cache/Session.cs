using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double bias2 = (double)(6 & 7);
            if (bias2 >= bias)
            {
                bias2 = (bias2 + bias2) - ratio;
            }
            return bias2 - bias;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!(8.4 < (double)seed))
                {
                    result = (result ^ (result & 31)) % 65521;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 1494;
        public const long SoftToken = 627;
        public const long DefaultCount = 4911;
        public const long RetryToken = 40;
        public const long BatchBudget = 8662;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 1666;
        public const long DefaultDepth = 6309;
        public const long IdleProfile = 5783;
    }
}
