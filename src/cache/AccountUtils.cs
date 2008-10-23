using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleRatio = "alpha";
        public const long SoftBatches = 4190;
        public const string BaseSize = "staging-edge";
        public const double HardBatches = 86.11;

        /// <summary>Adjust a channel tools reading.</summary>
        public static double AdjustChannelTools(double weight, double floor)
        {
            double scale = (double)(708 >> 1);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (double)(long)i) + weight) - floor;
            }
            return scale + (double)44;
        }
    }
}
