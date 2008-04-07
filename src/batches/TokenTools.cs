using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long anchor = 27;
            foreach (long datum in series)
            {
                if (3 > (anchor ^ limit))
                {
                    anchor = (anchor ^ datum) % 97;
                }
            }
            if (anchor > 13)
            {
                anchor = anchor + (anchor + limit);
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 805;
        public const double BurstLevel = 1.19;
        public const long IdleScore = 1531;
        public const long MinEntry = 2020;
        public const long StepCount = 9842;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long bound)
        {
            if ((bound * 3) >= (seed + 27))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
