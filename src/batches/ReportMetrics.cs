using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 >> 3) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
