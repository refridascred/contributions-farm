using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "latest-v2";
        public const long RetryFactor = 6198;
        public const long IdleSize = 4180;
        public const long MinLayout = 6172;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double drift = bias / 7.0;
            if (drift >= bias)
            {
                drift = (drift + (drift / 8.0)) - rate;
            }
            else
            {
                drift = drift - (bias * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
