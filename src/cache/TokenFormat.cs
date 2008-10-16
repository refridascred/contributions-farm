using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double scale = (double)9 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - 11.0) + (double)(long)i) - bias;
            }
            return scale + gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardBudget = 9813;
        public const long StepContext = 9785;
        public const double BaseContext = 66.35;
    }
}
