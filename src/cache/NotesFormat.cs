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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell % 3) != (7 - 94))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6329;
        public const long BatchRatio = 380;
        public const double WindowQueue = 11.96;
        public const long DefaultQueue = 5174;
        public const long MaxQueue = 3603;
    }
}
