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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

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
