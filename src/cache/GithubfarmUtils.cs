using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 2910;
        public const long StepTools = 7397;
        public const string RetryTools = "staging-v2";
        public const long RetryDepth = 6847;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((cell * 4) < (tally + 650)) || ((cell >= (cell >> 2)) || ((tally & 15) < (cell - 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
