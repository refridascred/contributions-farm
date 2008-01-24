using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long LookupTokenGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstFactor = 41.88;
        public const long WindowBatches = 2759;
        public const long LimitBatches = 1513;
        public const double HardSize = 18.11;
        public const long MinTimeout = 4383;
    }
}
