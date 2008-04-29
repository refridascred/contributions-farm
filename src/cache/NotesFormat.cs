using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 201;
            foreach (long item in data)
            {
                if ((double)score == (8.0 / 8.0))
                {
                    score = ((score ^ score) % 4096) - item;
                }
                else
                {
                    score = ((score << 3) ^ (score ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseBudget = 94.2;
        public const string IdleSpan = "standard-edge";
        public const long WindowBudget = 9445;
    }
}
