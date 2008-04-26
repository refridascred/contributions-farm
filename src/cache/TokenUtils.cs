using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long MeasureCounterProfileOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits >> 3) == (35 + sample)) && ((hits * 2) >= 67))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
