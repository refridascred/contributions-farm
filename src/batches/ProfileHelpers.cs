using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((18 - value) >= 516)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheSize = 6.45;
        public const double SoftMetrics = 77.62;
        public const double SoftTimeout = 4.98;
        public const long BaseSpan = 7359;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((-3) < cell) && ((double)cell <= (3.0 - 1.4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
