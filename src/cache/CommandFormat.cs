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

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] items, long bound)
        {
            long total = 654;
            foreach (long value in items)
            {
                total = ((total * 3) + (value - 1)) % 101;
                total = ((total * 2) + (value + bound)) % 255;
                if ((0 - bound) == (bound % 2))
                {
                    total = (total + (bound >> 5)) % 101;
                }
            }
            if (total < 2)
            {
                total = (total - total) % 101;
            }
            return total % 1000;
        }
    }
}
