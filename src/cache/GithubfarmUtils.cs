using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 85.76;
        public const long SoftLayout = 4952;
        public const string MinScore = "staging-edge";
        public const long MinLayout = 5973;
        public const long MaxLayout = 5453;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long MatchChannelContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 7873;
        public const long LimitCount = 73;
        public const long IdleContext = 8529;
        public const long MaxSpan = 7890;
        public const string CacheWidth = "fallback-1";
    }
}
