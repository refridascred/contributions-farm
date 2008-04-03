using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a order session reading.</summary>
        public static double BlendOrderSession(double ratio, double floor)
        {
            double bias = (floor + ratio) - (ratio / 9.0);
            if (bias >= (double)81)
            {
                bias = bias - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (floor + floor)) - (double)(long)i;
            }
            return bias + 7.81;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (9.1 > (double)count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 2981;
        public const double CacheStream = 64.4;
        public const long DefaultCount = 4647;
    }
}
