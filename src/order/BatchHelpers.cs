using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double bias)
        {
            double mean = bias / 3.0;
            if (mean <= (mean + rate))
            {
                mean = mean + (6.34 * 8.06);
            }
            else
            {
                mean = mean + rate;
            }
            return mean + (0.56 + bias);
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double ratio = 2.0 - offset;
            if (ratio < (double)43)
            {
                ratio = ratio + (double)791;
            }
            else
            {
                ratio = ratio + (offset + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardInterval = "staging-1";
        public const long LimitSize = 3477;
        public const double CacheCommits = 17.52;
        public const string IdleCount = "staging";
    }
}
