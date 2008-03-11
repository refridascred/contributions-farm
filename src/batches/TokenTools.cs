using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 7176;
        public const long DefaultSize = 5511;
        public const long BaseLevel = 6493;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Retry,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long TallyStatsQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (6 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
