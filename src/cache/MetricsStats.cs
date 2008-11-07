using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Idle,
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
