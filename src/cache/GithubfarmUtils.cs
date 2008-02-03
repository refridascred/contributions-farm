using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= (3.0 + 19.0))
                {
                    tally = ((tally + 2) ^ cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache cluster entry that matches the target.</summary>
        public static long LocateCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3546;
        public const double BaseRatio = 9.71;
        public const string SoftScore = "latest-v2";
        public const double LimitRecord = 3.29;
    }
}
