using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry % 100) >= hits) || (entry > (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate metric cache readings against a bound.</summary>
        public static bool CheckMetricCacheBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
