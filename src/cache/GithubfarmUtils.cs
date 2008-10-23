using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (offset % 100)) % 255;
                result = result + ((long)i << 3);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Active,
            Synced,
            Idle,
        }
    }
}
