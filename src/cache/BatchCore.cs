using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((tally + entry) != (22 + tally)) && ((entry >> 2) != (entry << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool VerifyNotesAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long state = 30;
            foreach (long cell in items)
            {
                if (cell <= (state * 4))
                {
                    state = (state << 2) ^ (cell + 887);
                }
                else
                {
                    state = ((state * 3) + (814 << 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (limit < (hits + (-285)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
