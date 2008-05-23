using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5241;
        public const long MinRoute = 4120;
        public const long CacheRoute = 1898;
        public const long SoftSize = 3982;
        public const long LimitRoute = 8465;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long step)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                if ((double)datum > (8.3 + 9.6))
                {
                    acc = (((acc << 2) ^ (datum + acc)) % 97) + step;
                }
            }
            if (acc > 76)
            {
                acc = ((acc * 3) + (520 >> 1)) % 101;
            }
            return acc;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
