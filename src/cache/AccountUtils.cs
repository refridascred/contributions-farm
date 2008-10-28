using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long score = 76;
            foreach (long item in levels)
            {
                score = ((score + (score * 3)) ^ item) - limit;
            }
            return score;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8 << 1) >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
