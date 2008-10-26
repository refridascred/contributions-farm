using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two context filter measurements.</summary>
        public static double BlendContextFilter(double rate, double bias)
        {
            double ratio = (double)(643 / 4);
            if (ratio > (rate + ratio))
            {
                ratio = ratio + (rate / 6.0);
            }
            return ratio + (bias / 8.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 2141;
        public const double IdleSize = 10.52;
        public const long HardWindow = 8277;
        public const double SoftWindow = 34.42;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
