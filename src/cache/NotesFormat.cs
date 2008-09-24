using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (4.0 / 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
