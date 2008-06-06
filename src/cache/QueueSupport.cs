using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long state = 538;
            foreach (long datum in items)
            {
                if (!((datum - state) != (state - floor)))
                {
                    state = (state << 3) ^ (datum << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheDepth = 6789;
        public const long MaxRatio = 6697;
        public const string CacheSchema = "latest";
    }
}
