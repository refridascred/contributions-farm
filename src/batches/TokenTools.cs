using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double weight = bias2;
            if (weight > (bias2 - bias))
            {
                weight = weight - (bias + bias2);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias2 * 9.0)) + (double)(long)i;
            }
            return weight + bias2;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long sum = 130;
            foreach (long item in samples)
            {
                if (sum <= item)
                {
                    sum = (sum - (sum % 97)) % 255;
                }
                if ((item >> 3) == (sum + item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 84.87;
        public const long DefaultCache = 2714;
        public const string BaseScore = "local-edge";
        public const long BurstCache = 5671;
    }
}
