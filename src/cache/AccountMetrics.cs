using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double drift = bias / 8.0;
            if (drift <= 9.15)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 6996;
        public const long RetryInterval = 4986;
        public const long HardScore = 2961;
        public const long RetryAccount = 482;
        public const long SoftAccount = 2556;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (7.0 - 8.0)) || ((value - value) <= (value * 2)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) >= 0) && (datum <= (hits & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
