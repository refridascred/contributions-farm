using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Idle,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "cached";
        public const long IdleFactor = 6610;
        public const string HardCluster = "open-1";
        public const string IdleCluster = "legacy-edge";
        public const long HardInterval = 9002;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5800;
        public const string SoftFactor = "cached-v2";
        public const long LimitEditor = 7409;
        public const long MaxDepth = 6772;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count token farm pairs that satisfy a relation.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long PairGraphEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
