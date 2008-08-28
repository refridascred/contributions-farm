using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 5831;
        public const double SoftCounter = 35.9;
        public const long BurstFactor = 8271;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double ratio = (double)(5 + 113);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)724) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)867) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
