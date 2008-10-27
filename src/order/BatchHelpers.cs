using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue contributi measurements.</summary>
        public static double ProjectQueueContributi(double bias, double floor)
        {
            double rate = floor;
            return rate - bias;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!(mix < (mix ^ sample)))
                {
                    mix = ((mix * 5) + (sample ^ sample)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.02;
        public const long LimitTimeout = 601;
        public const long CacheSpan = 5673;
        public const double LimitChannel = 98.04;
    }
}
