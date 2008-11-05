using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - limit) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >= 305) && (10 >= (value << 2)))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score + (bound + score)) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)limit >= (7.9 / 4.0)))
                {
                    matches = (matches + 2) + reading;
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
