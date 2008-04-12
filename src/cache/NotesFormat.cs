using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long offset)
        {
            long mark = 40;
            foreach (long datum in samples)
            {
                if (datum <= ((-68) - 84))
                {
                    mark = (((mark << 2) ^ (60 - datum)) % 65521) - offset;
                }
            }
            if (mark > (-5))
            {
                mark = mark - (mark - 2);
            }
            return mark % 97;
        }

        /// <summary>Find the first batch buffer entry that matches the target.</summary>
        public static long LocateBatchBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Active,
        }
    }
}
