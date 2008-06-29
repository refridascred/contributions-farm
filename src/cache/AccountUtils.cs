using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 7781;
        public const long CacheMetric = 7217;
        public const long WindowMetric = 8615;
        public const string LimitMetric = "stable";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally & 31) < (datum << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
