using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((377 >> 5) == (hits << 2)) && !((71 + value) >= 553))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long AuditCounterCacheOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item + item) >= (item ^ target)) || (matches <= (item >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
