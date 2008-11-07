using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - 18) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Pending,
            Paused,
        }
    }
}
