using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long offset)
        {
            long score = 76;
            foreach (long item in samples)
            {
                if ((item & 15) != (score + item))
                {
                    score = ((score << 2) ^ score) + offset;
                }
                else
                {
                    score = ((score << 3) ^ (131 + 49)) % 65521;
                }
                if ((15 & 127) > (item * 4))
                {
                    score = (score ^ 31) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4758;
        public const long BatchFactor = 7221;
        public const long SoftSize = 247;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
