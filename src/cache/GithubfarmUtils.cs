using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((origin + sample) <= (sample - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long IterateFarmTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ (seed * 5);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Dropped,
            Ready,
            Paused,
        }
    }
}
