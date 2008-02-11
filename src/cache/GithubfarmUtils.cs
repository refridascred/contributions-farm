using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1031;
        public const long BaseQueue = 5356;
        public const double BatchQueue = 69.07;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (12 ^ 0)) % 4096;
                score = score + score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
