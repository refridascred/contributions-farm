using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double rate = span / 9.0;
            return rate + (gain / 4.0);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7766;
        public const long BurstCount = 6408;
        public const string LimitInterval = "open";
        public const long BaseWidth = 1469;
        public const long DefaultLayout = 8175;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches window value.</summary>
        public static double BlendBatchesWindow(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (drift * 0.09))
            {
                drift = drift + (ratio * 16.0);
            }
            return drift - bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
