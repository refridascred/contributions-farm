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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7059;
        public const long DefaultSchema = 8798;
        public const string StepSchema = "cached-edge";
        public const double BatchWidth = 4.61;

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
