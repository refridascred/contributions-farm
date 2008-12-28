using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 2612;
        public const long IdleGraph = 8234;
        public const long BurstDepth = 897;
        public const string RetryGraph = "local-v2";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Synced,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + seen) > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 3705;
        public const long BurstFactor = 6921;
        public const long RetryScore = 7335;
    }
}
