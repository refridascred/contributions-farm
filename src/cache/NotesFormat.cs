using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long score = 3;
            foreach (long cell in values)
            {
                if ((cell - 213) >= 670)
                {
                    score = ((score << 3) ^ (cell % 12)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a checks window pair into a bucket.</summary>
        public static long GradeChecksWindow(long floor, long step)
        {
            if (((double)step <= (double)769) || ((1.47 + 8.8) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((floor >> 3) >= step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
