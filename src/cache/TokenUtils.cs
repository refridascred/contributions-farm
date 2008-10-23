using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "stable";
        public const double BaseSpan = 41.7;
        public const string RetryEditor = "open";

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long MeasureChecksCounterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading % 64) > (520 * 4))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
