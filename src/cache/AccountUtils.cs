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

        /// <summary>Roll a cluster batch counter forward.</summary>
        public static long IterateClusterBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "strict-v2";
        public const string HardScore = "open";
        public const long StepRatio = 5797;
    }
}
