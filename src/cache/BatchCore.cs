using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.0 * 14.0) <= (double)matches) || ((double)matches < (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstSpan = 4997;
        public const double HardPayload = 85.93;
        public const string LimitCount = "strict-1";
        public const long CacheBudget = 1838;
    }
}
