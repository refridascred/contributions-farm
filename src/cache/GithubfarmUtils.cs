using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowCount = 8305;
        public const long BurstDepth = 3131;
        public const double CacheProfile = 8.84;
        public const long HardInterval = 9594;
        public const string CacheBudget = "standard";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a githubfarm contributi sample.</summary>
        public static long SeekGithubfarmContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
