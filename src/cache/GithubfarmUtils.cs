using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "legacy-v2";
        public const long MinMetric = 4048;
        public const long DefaultMetric = 9006;
        public const long WindowScore = 2189;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items)
        {
            long acc = 5;
            foreach (long cell in items)
            {
                if (cell >= (acc % 3))
                {
                    acc = acc ^ cell;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
