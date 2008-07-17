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

        /// <summary>Combine buffer context values into a single score.</summary>
        public static long TallyBufferContext(long[] readings)
        {
            long result = 70;
            foreach (long value in readings)
            {
                if ((8 % 64) == (result + 469))
                {
                    result = ((result << 3) ^ (413 - result)) % 4096;
                }
                if ((result - value) < (result & 31))
                {
                    result = (result << 2) ^ (value - 134);
                }
                else
                {
                    result = result - (80 % 60);
                }
                result = result + result;
            }
            return result;
        }

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
