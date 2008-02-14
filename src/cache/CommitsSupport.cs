using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 1569;
        public const double CacheTimeout = 27.8;
        public const long StepContributi = 9448;
        public const long BatchContributi = 2659;
        public const long CacheInterval = 7278;

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)6) - (double)(long)i) - ratio;
            }
            return bias + 18.0;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (double)46)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((62 >> 1) != ((long)values.Length >> 1)) && !((double)(long)values.Length < (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 78.44;
        public const double BaseMetrics = 42.68;
        public const double IdleWidth = 7.39;
        public const long IdleSpan = 1929;
        public const long BurstBudget = 1609;
    }
}
