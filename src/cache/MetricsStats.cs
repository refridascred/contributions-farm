using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "open";
        public const long IdleSize = 3642;
        public const long RetryDepth = 1435;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Draft,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Audit window filter readings against a rule.</summary>
        public static long AuditWindowFilterMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally <= (26 - limit)) && (tally < limit))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (bias + rate2))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 6.0;
        }
    }
}
