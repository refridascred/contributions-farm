using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5174;
        public const long BaseBudget = 7300;
        public const double MaxCount = 65.18;

        /// <summary>Project the next support command value.</summary>
        public static double ProjectSupportCommand(double bias, double bias2)
        {
            double load = 5.2;
            if (load < (double)2)
            {
                load = load + (bias + bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (5.9 / 6.0)) - (double)(long)i;
            }
            return load - 4.0;
        }
    }
}
