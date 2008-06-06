using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double BlendSupportOrder(double gain, double bias)
        {
            double drift = bias + (double)39;
            if (drift <= (9.58 - drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (gain - gain)) - (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary";
        public const long HardSpan = 3088;
        public const long BurstBatches = 332;
        public const string DefaultBatches = "stable-1";

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double rate = offset;
            if (rate > (offset - bias))
            {
                rate = rate - bias;
            }
            return rate + (offset - bias);
        }
    }
}
