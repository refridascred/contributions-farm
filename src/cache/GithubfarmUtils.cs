using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((reading >> 4) == (78 & 7)))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleTimeout = 76.85;
        public const double StepWidth = 27.03;
        public const long DefaultWidth = 1142;
        public const long HardQueue = 9753;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
