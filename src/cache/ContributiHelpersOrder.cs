using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinSpan = "staging";
        public const double WindowRoute = 92.59;
        public const long RetryRoute = 5218;
        public const long BaseRoute = 8943;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((seed ^ 1) < (hits / 7))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
