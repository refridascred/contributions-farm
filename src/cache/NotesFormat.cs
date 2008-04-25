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

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (acc - (entry & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Done,
            Dropped,
            Locked,
        }
    }
}
