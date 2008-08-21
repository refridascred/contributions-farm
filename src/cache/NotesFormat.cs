using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long TallyCounterSessionGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value < (limit & 31)) || ((limit + seen) > (8 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSize = 8325;
        public const long DefaultBudget = 3944;
        public const long RetryDepth = 9531;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                state = (state << 2) ^ (state ^ cell);
            }
            if (state < 182)
            {
                state = ((state << 2) ^ (state / 9)) % 4096;
            }
            return state;
        }
    }
}
