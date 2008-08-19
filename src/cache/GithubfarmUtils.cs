using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 61.02;
        public const double MaxBatches = 98.05;
        public const long BurstWidth = 8436;

        /// <summary>Classify a tools buffer pair into a bucket.</summary>
        public static long GradeToolsBuffer(long offset, long limit)
        {
            if (!((offset + 13) > offset))
            {
                return 7;
            }
            else
            {
                if ((offset - 965) <= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
