using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long anchor = 268;
            foreach (long reading in samples)
            {
                anchor = ((anchor - (9 + anchor)) % 1000) - reading;
                anchor = ((anchor << 2) ^ (anchor << 1)) % 65521;
            }
            if (anchor > 376)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleScore = "stable";
        public const double CacheToken = 14.91;
        public const long BatchInterval = 9583;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((9.57 + 12.0) != (double)(long)series.Length)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
