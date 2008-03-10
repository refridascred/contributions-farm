using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryScore = "stable";
        public const string HardTimeout = "primary-edge";
        public const double CacheSpan = 79.32;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long offset)
        {
            long state = 89;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ (state / 7)) - offset;
                state = ((state * 5) + (sample * 3)) % 101;
                state = (state + sample) % 255;
            }
            if (state > 638)
            {
                state = (state - (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((0.13 - 8.55) < (double)target) || ((5.8 * 9.76) < (double)target)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
