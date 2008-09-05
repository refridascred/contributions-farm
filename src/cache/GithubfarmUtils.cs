using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window contributi entries.</summary>
        public static long TotalWindowContributi(long[] data, long floor)
        {
            long carry = 595;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry > (-739))
            {
                carry = carry - (floor % 100);
            }
            return carry;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long SeekSupportFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 626;
        public const long IdleSize = 7376;
        public const long MinLevel = 8364;
        public const string CacheWidth = "staging";
        public const long BurstSize = 6481;
    }
}
