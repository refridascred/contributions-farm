using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream graph value from a seed.</summary>
        public static long IterateStreamGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((state ^ state) > (long)i)
                {
                    state = state - ((long)i & 31);
                    state = state + origin;
                }
                state = state + ((long)i + origin);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((298 & 3) > seed))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheDepth = 84.24;
        public const long BatchRatio = 1698;
        public const double HardToken = 47.36;
        public const long BaseWidth = 8626;
    }
}
