using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already order figure with a bias.</summary>
        public static double ProjectAlreadyOrder(double bias, double bias2)
        {
            double bias3 = 5.1;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias + bias)) - (double)(long)i) - bias2;
            }
            return bias3 - (double)2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "legacy-1";
        public const long BurstSize = 1552;
        public const string DefaultWidth = "primary-1";
        public const long WindowCommits = 161;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
