using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if ((712 & 7) < (item - result))
                {
                    result = ((result << 2) ^ (item - 6)) % 97;
                }
                else
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            return result;
        }
    }
}
