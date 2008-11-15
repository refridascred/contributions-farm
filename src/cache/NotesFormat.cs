using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a batch queue reading by value.</summary>
        public static long SeekBatchQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((8.9 * 2.0) < (double)seed))
                {
                    score = (score ^ ((long)i + (long)i)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7440;
        public const string WindowInterval = "strict-1";
        public const string MaxStream = "local";
    }
}
