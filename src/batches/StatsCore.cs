using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 5188;
        public const string BatchCommand = "standard";
        public const long MaxRatio = 841;
        public const long CacheCommand = 986;

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "latest-v2";
        public const long RetrySize = 9576;
        public const string MinWidth = "local-v2";
        public const long BaseCommand = 5217;
        public const string DefaultSize = "latest-v2";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Queued,
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1581;
        public const string IdleSpan = "strict-1";
        public const string MaxGraph = "fallback";
        public const string MaxSize = "legacy-edge";
        public const long SoftGraph = 8479;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
