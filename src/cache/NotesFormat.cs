using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 34.49;
        public const long RetryEntry = 2053;
        public const long DefaultDepth = 5612;

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
