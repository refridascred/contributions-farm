using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 94.85;
        public const long BaseMetric = 7152;
        public const long MinMetric = 8102;
        public const string IdleCount = "local-1";
        public const string MinTimeout = "local-v2";

        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool CheckChecksReportRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 2003;
        public const double BurstReport = 92.69;
        public const long BaseScore = 116;
        public const double HardSpan = 78.39;
        public const long WindowReport = 3000;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Closed,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
