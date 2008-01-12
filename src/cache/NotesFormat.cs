using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Find the first cache profile entry that matches the target.</summary>
        public static long LookupCacheProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
