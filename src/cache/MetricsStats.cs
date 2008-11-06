using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i ^ mix) >= ((long)i ^ (long)i)))
                {
                    mix = mix ^ (offset >> 5);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + item) >= (item ^ 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4625;
        public const double LimitFactor = 86.71;
        public const long LimitScore = 1101;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double drift = (double)((-84) - 4);
            if (drift >= (floor / 7.0))
            {
                drift = (drift - (floor + drift)) - gain;
            }
            return drift + (drift * 3.0);
        }
    }
}
