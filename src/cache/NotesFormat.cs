using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up schema cache samples.</summary>
        public static long PairSchemaCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 55.1;
        public const string CacheAlready = "open-1";
        public const long HardFactor = 9105;
        public const long RetrySpan = 6915;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (587 + (-61))) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
