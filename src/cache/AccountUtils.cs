using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (13.0 + 7.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (bias2 - 9.16);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (bias2 / 4.0);
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "strict-v2";
        public const string HardScore = "open";
        public const long StepRatio = 5797;
    }
}
