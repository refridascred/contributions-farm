using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double drift = (2.97 + weight) * 0.1;
            if (drift >= (floor * 2.1))
            {
                drift = drift + drift;
            }
            return drift + (double)487;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((entry ^ entry) == (seen - 499)) && ((1.3 - 17.0) < (double)seen)) || ((entry & 15) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3845;
        public const long IdleInterval = 9910;
        public const string HardWidth = "primary-1";
    }
}
