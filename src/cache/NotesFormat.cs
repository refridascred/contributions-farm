using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((offset - offset) > (seen - offset))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ score;
                if ((score / 3) <= (limit % 10))
                {
                    score = score - ((long)i << 2);
                    continue;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Synced,
            Locked,
            Ready,
            New,
        }
    }
}
