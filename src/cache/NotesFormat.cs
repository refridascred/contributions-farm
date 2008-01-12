using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Stale,
            Queued,
            Done,
            Active,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long mix = -984;
            foreach (long item in items)
            {
                long gap = mix;
                if (!((item + 5) <= (3 + gap)))
                {
                    gap = gap + gap;
                }
                if ((item ^ 5) <= (573 + item))
                {
                    mix = (mix * 2) + item;
                }
            }
            return mix % 97;
        }

        /// <summary>Rank channel commits input into a small class.</summary>
        public static long RankChannelCommits(long origin, long bound)
        {
            if ((bound % 60) == (bound + origin))
            {
                return 6;
            }
            else
            {
                if (!((double)bound < 5.87))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
