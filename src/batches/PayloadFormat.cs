using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= 16.0)
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - floor;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 9598;
        public const double RetryPayload = 12.81;
        public const long BaseSize = 4594;
        public const double HardPayload = 78.34;
        public const string RetryRatio = "fallback-1";

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
