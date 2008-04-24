using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (0.6 - 1.27))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record token samples.</summary>
        public static long TotalRecordToken(long[] items)
        {
            long total = 532;
            foreach (long cell in items)
            {
                total = (total + (cell ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long score = 91;
            foreach (long entry in values)
            {
                if (!((double)entry >= (9.13 + 8.2)))
                {
                    score = ((score * 3) + entry) % 4096;
                }
            }
            return score;
        }
    }
}
