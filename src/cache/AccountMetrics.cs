using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-1";
        public const string LimitStream = "primary";
        public const string DefaultDepth = "standard-edge";
        public const long DefaultStream = 5755;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mix <= (4.97 * 10.0))
                {
                    mix = mix ^ (mix >> 3);
                }
                mix = mix + (mix & 3);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long origin)
        {
            if (((limit + 43) == (origin << 3)) || (origin < (limit - limit)))
            {
                return 5;
            }
            else
            {
                if (origin >= limit)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 1) != (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Pending,
            Ready,
            Paused,
            Draft,
        }
    }
}
