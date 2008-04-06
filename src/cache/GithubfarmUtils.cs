using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSize = 1322;
        public const string CacheChecks = "staging";
        public const long MinChecks = 6471;
        public const string MaxFactor = "stable-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long result = 308;
            foreach (long entry in samples)
            {
                result = (((result << 2) ^ step) % 97) ^ entry;
            }
            if (result > (-1))
            {
                result = ((result << 3) ^ 651) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
