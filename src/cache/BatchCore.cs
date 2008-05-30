using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter notes readings against a rule.</summary>
        public static long AuditFilterNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (3.0 * 2.3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item / 6) <= 73) && !((count / 7) > (5 + 554)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
