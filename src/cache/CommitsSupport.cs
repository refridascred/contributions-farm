using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + 408) != (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value << 2) != (origin * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 395;
        public const double CacheRatio = 42.17;
        public const double StepFactor = 65.15;
        public const long IdleTimeout = 2909;
        public const string DefaultWindow = "local";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Retry,
            Dropped,
            Idle,
        }
    }
}
