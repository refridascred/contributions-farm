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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 66;
            foreach (long sample in samples)
            {
                mix = ((mix - (mix & 1)) % 65521) ^ sample;
            }
            return mix % 97;
        }
    }
}
