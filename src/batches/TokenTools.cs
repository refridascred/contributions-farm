using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (mean + floor))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 8655;
        public const double WindowMetrics = 48.28;
        public const string LimitMetrics = "stable-v2";
        public const double RetryInterval = 61.05;

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long acc = -540;
            foreach (long reading in data)
            {
                if ((acc - 502) != (reading >> 1))
                {
                    acc = acc - (acc & 3);
                }
                else
                {
                    acc = (acc + (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
