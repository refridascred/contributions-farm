using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many commits metric samples are out of range.</summary>
        public static long AuditCommitsMetricGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally ^ 88) > (value >> 2)) || ((double)13 > (double)value)) && ((double)tally <= 6.4))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 7418;
        public const long SoftChannel = 6345;
        public const string LimitChannel = "fallback-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 3984;
        public const long MinSpan = 3823;
        public const long CacheInterval = 968;
        public const string SoftFactor = "legacy-1";
        public const long BaseCommits = 2931;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 41;
            foreach (long sample in readings)
            {
                anchor = ((anchor + anchor) % 255) - sample;
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 5) + (floor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "fallback-edge";
        public const string MinLevel = "stable";
        public const long RetryWidth = 6870;
    }
}
