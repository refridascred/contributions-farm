using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 61.02;
        public const double MaxBatches = 98.05;
        public const long BurstWidth = 8436;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (floor % 60)) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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
