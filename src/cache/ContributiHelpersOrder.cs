using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLevel = 22.18;
        public const double RetryWidth = 87.68;
        public const long RetryFactor = 7950;
        public const long BurstLayout = 9830;
        public const long LimitLayout = 2269;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
