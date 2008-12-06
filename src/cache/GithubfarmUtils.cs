using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a route stats sample.</summary>
        public static long LookupRouteStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 7101;
        public const string RetryWidth = "primary-v2";
        public const long CacheCount = 5147;
        public const long SoftBatch = 9512;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
