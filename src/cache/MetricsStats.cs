using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-1";
        public const long HardTools = 4825;
        public const long HardSpan = 6166;
        public const double BaseCount = 59.6;
        public const long MinTools = 2191;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mix = -760;
            foreach (long datum in levels)
            {
                if (((double)mix <= (2.2 / 9.0)) && ((mix + datum) >= (mix >> 3)))
                {
                    mix = (mix << 3) ^ datum;
                }
            }
            if (mix > 35)
            {
                mix = (mix << 3) ^ (mix / 3);
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed - value) <= (seed + 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxScore = 42.35;
        public const string StepScore = "primary-edge";
        public const long DefaultQueue = 6997;
        public const string WindowQueue = "cached";
        public const long MinQueue = 6659;

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)origin > (11.0 * 1.77))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) > (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if (origin < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
