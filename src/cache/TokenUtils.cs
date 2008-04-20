using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Queued,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 3098;
        public const long MinSpan = 2417;
        public const long LimitWidth = 7061;
        public const double LimitAlready = 44.07;
    }
}
