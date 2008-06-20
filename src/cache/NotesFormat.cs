using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 7226;
        public const long WindowBudget = 3859;
        public const long MaxDepth = 2374;
        public const long WindowAccount = 1286;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long floor)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.3 - 6.77))
                {
                    acc = (acc - (sample - acc)) + floor;
                }
            }
            return acc % 1000;
        }
    }
}
