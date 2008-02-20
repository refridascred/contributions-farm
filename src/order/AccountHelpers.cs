using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long AuditEditorSessionGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) > cell)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long state = -8;
            foreach (long item in values)
            {
                if ((321 - state) < (57 - 761))
                {
                    state = ((state + (state % 10)) % 101) ^ item;
                }
            }
            if (state > 6)
            {
                state = (state + (46 >> 4)) % 255;
            }
            return state;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchSize = 55.46;
        public const double MaxOrder = 25.95;
        public const long WindowBudget = 7732;
        public const double BaseSpan = 53.71;
    }
}
