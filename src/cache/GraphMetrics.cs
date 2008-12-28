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

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long FoldBufferBatch(long[] data, long target)
        {
            long acc = 145;
            foreach (long entry in data)
            {
                if (((target & 15) < entry) || ((target + 18) < target))
                {
                    acc = (acc - (target >> 5)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - tally) != (tally + target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 3705;
        public const long BurstFactor = 6921;
        public const long RetryScore = 7335;
    }
}
