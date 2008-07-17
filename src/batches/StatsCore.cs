using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a batches format figure with a bias.</summary>
        public static double ScaleBatchesFormat(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (2.0 * 7.7)) + (double)(long)i) + gain;
            }
            return drift - drift;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 27;
            foreach (long cell in levels)
            {
                if (7 > (anchor * 4))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryRatio = 97.37;
        public const long BurstLevel = 912;
        public const long LimitInterval = 7674;
        public const string CacheInterval = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSize = 6023;
        public const long SoftCount = 9279;
        public const long LimitTimeout = 4712;
        public const string BurstRatio = "local";
        public const long RetrySize = 2618;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (scale / 6.0)) + (double)(long)i;
            }
            return bias2 + 4.0;
        }
    }
}
