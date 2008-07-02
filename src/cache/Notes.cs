using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            if ((offset >= (6 >> 1)) || (1 <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset / 6) < (547 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) >= 600)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 8511;
        public const long BaseTools = 5560;
        public const long IdleTools = 4078;
        public const string MaxTools = "latest";
        public const long BatchSize = 1233;

        /// <summary>Count the token stats entries that pass the check.</summary>
        public static long TallyTokenStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 2) == (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseDepth = "primary-1";
        public const long LimitSpan = 2623;
        public const double MinScore = 81.7;
        public const long WindowFormat = 6574;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 7517;
        public const long LimitTools = 7300;
        public const long BaseRatio = 4580;
        public const long DefaultTools = 9439;
        public const string MaxLevel = "staging-v2";
    }
}
