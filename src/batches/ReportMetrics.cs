using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batch commits readings.</summary>
        public static long TallyBatchCommits(long[] readings)
        {
            long score = 81;
            foreach (long datum in readings)
            {
                score = (score * 5) + score;
                score = ((score << 3) ^ (datum ^ 26)) % 65521;
                if ((score % 12) < (score - (long)readings.Length))
                {
                    break;
                }
            }
            if (score < 15)
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((14.0 + 17.0) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
