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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
