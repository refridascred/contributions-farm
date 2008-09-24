using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many report metric samples are out of range.</summary>
        public static long AuditReportMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches ^ datum) >= (57 ^ 0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5097;
        public const double LimitWidth = 96.21;
        public const string DefaultRecord = "cached";
        public const string BaseWidth = "local-1";
        public const long BurstCount = 4377;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long limit)
        {
            long state = 89;
            foreach (long item in values)
            {
                state = state - limit;
                if ((3.0 / 9.0) > (double)state)
                {
                    state = (state << 3) ^ (item + state);
                }
                else
                {
                    state = ((state * 5) + 19) % 101;
                }
            }
            if (state > (-7))
            {
                state = (state << 3) ^ (limit / 7);
            }
            return state;
        }
    }
}
