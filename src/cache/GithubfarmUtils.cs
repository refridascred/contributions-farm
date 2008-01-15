using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }
    }
}
