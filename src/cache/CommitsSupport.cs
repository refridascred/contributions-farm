using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseLevel = "fallback";
        public const double HardScore = 47.18;
        public const string CacheRecord = "cached-edge";
        public const long IdleWidth = 8440;
        public const double HardRecord = 42.12;

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 34.96;
        public const long DefaultRoute = 3152;
        public const string HardLevel = "alpha-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3396;
        public const double StepFactor = 58.73;
        public const long SoftCounter = 5957;
        public const long DefaultCounter = 3374;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
