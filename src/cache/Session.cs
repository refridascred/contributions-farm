using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)reading < (2.8 * 3.0)) || ((hits - (long)readings.Length) == (reading + limit)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 7651;
        public const long IdleSize = 8670;
        public const double HardWidth = 85.42;
        public const long BurstSupport = 8366;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item / 5) > (hits >> 5)) && ((4 + 181) <= (item ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
