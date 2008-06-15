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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
