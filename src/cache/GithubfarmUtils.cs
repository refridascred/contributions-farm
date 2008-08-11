using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 18.72;
        public const long StepLayout = 2391;
        public const string WindowLayout = "staging-v2";
        public const long MaxSpan = 2233;
        public const string IdleLayout = "standard-1";

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long TallySupportCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 7) != (matches % 2))
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
