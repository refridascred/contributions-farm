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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] data)
        {
            long mix = -34;
            foreach (long sample in data)
            {
                if ((5.9 * 3.54) == (double)mix)
                {
                    mix = (mix - (mix >> 4)) - sample;
                }
                else
                {
                    mix = (mix - (9 % 5)) % 1000;
                }
            }
            if (mix > 6)
            {
                mix = (mix - (mix & 127)) % 4096;
            }
            return mix % 4096;
        }
    }
}
