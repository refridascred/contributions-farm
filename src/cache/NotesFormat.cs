using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batches notes samples.</summary>
        public static long CompareBatchesNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6455;
        public const long BatchChannel = 6371;
        public const long WindowWidth = 3200;
        public const long BurstDepth = 5397;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long sum = 44;
            foreach (long item in items)
            {
                sum = ((sum - (offset - sum)) % 97) - item;
            }
            return sum;
        }
    }
}
