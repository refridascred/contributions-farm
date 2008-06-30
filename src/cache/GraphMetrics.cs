using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry checks readings.</summary>
        public static long CombineEntryChecks(long[] series, long limit)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((long)series.Length < (835 << 1))
                {
                    score = ((score - limit) % 97) - item;
                }
                else
                {
                    score = ((score * 3) + (limit * 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Active,
            Synced,
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long TallySupportTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally <= (7.0 + 8.8))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= (553 - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((809 + count) <= item) || ((item >> 1) <= item))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
