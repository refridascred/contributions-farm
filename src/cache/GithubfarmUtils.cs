using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((seed ^ seed) > (matches & 127))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a format checks counter forward.</summary>
        public static long RollFormatChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((score << 3) < 121))
                {
                    score = (score + (step << 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Draft,
            Pending,
            Locked,
            Stale,
        }
    }
}
