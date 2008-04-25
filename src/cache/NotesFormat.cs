using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next buffer queue value from a seed.</summary>
        public static long DeriveBufferQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 4096;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
