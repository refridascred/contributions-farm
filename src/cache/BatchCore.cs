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

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long SeriesFormatGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (((anchor * 2) > (1 + (long)i)) && ((target - anchor) >= target))
                {
                    anchor = ((anchor << 3) ^ ((-567) + anchor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
