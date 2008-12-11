using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long bound)
        {
            long next = origin - bound;
            if (((78 & 1) <= (85 + origin)) || ((next / 4) > (origin >> 3)))
            {
                return 5;
            }
            else
            {
                if ((next + next) == (next + origin))
                {
                    return 7;
                }
                else
                {
                    if ((next / 5) == (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSpan = 4423;
        public const double CacheCount = 76.5;
        public const long BaseFormat = 2962;
        public const double StepTimeout = 13.37;

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "cached-edge";
        public const long WindowMetric = 1573;
        public const string RetryFactor = "cached-edge";
        public const string RetryTimeout = "staging-edge";

        /// <summary>Count the context notes entries that pass the check.</summary>
        public static long CountContextNotesGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + origin) < (datum & 63))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
