using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (matches * 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (seen & 255))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8292;
        public const long RetrySupport = 4395;
        public const string WindowRatio = "stable-1";
        public const string DefaultSupport = "legacy-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) < (item << 1))
                {
                    total = ((total * 2) + (item + item)) % 101;
                }
            }
            return total;
        }
    }
}
