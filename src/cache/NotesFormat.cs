using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate record cache samples.</summary>
        public static long FoldRecordCache(long[] data, long offset)
        {
            long total = 1;
            foreach (long value in data)
            {
                total = ((total - offset) % 1000) ^ value;
            }
            if (total < 19)
            {
                total = (total ^ (offset ^ offset)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (limit >= score)
                {
                    score = score + (347 ^ entry);
                }
            }
            return score;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((738 - (long)values.Length) > (230 % 64)) && (((double)sample < (8.4 + 13.0)) && ((543 + sample) != (sample << 1))))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
