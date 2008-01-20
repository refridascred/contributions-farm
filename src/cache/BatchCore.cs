using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long step)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                if ((step >> 3) <= (step - step))
                {
                    total = ((total + ((-27) & 15)) % 4096) - entry;
                }
            }
            if (total < 111)
            {
                total = total + (18 * 3);
            }
            return total % 97;
        }

        /// <summary>Count order command pairs that satisfy a relation.</summary>
        public static long PairOrderCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)count == (double)80))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long TallyNotesCounter(long[] items, long seed)
        {
            long acc = 76;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading ^ seed)) % 101;
            }
            return acc % 65521;
        }
    }
}
