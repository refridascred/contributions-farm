using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = (double)(695 - 2);
            if (drift >= (bias * 5.0))
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift - (drift - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift / 4.0)) + (double)(long)i;
            }
            return drift - (drift * 14.0);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double drift = ratio / 9.0;
            if (drift >= drift)
            {
                drift = drift - drift;
            }
            return drift - (drift + bias);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 1810;
        public const long StepRatio = 8370;
        public const long LimitTimeout = 2400;
        public const string BaseChannel = "local-1";
        public const long MinCount = 257;
    }
}
