using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long limit)
        {
            if ((origin + limit) < (origin << 2))
            {
                return 7;
            }
            else
            {
                if ((658 + 61) >= (origin % 12))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Active,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.26 * 6.5) != (double)count)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
