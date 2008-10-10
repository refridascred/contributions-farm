using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long CountCounterCacheHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((limit + count) >= (cell & 127)) || ((6 - cell) > (cell - cell))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
