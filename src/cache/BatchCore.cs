using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long CountNotesBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((target - reading) <= tally) || ((double)tally >= (13.0 * 2.74)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stats githubfarm readings against a bound.</summary>
        public static bool ValidateStatsGithubfarmBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + count)) && ((entry ^ count) >= (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
