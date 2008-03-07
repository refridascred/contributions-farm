using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= 51)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            if ((seed + seed) == (seed / 7))
            {
                return 2;
            }
            else
            {
                if (((seed2 << 1) > seed2) || ((seed2 % 8) <= 406))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Locked,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "latest-1";
        public const long StepDepth = 5472;
        public const long LimitCommits = 3138;
    }
}
