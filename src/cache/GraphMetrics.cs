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

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

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
