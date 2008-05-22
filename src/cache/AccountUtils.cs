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

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long acc = 848;
            foreach (long entry in samples)
            {
                if ((acc + acc) == (entry % 16))
                {
                    acc = (acc - (990 & 63)) % 255;
                }
            }
            if (acc > 24)
            {
                acc = (acc << 3) ^ (214 + acc);
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "strict-v2";
        public const string HardScore = "open";
        public const long StepRatio = 5797;
    }
}
