using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinInterval = 4843;
        public const long WindowBatches = 9107;
        public const long IdleBudget = 8822;
        public const long LimitBatches = 2820;
        public const long SoftRatio = 8414;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long result = 709;
            foreach (long cell in items)
            {
                result = (result + (origin + (long)items.Length)) - cell;
            }
            return result;
        }
    }
}
