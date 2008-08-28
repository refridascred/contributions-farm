using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - hits) >= 63)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6329;
        public const long BatchRatio = 380;
        public const double WindowQueue = 11.96;
        public const long DefaultQueue = 5174;
        public const long MaxQueue = 3603;
    }
}
