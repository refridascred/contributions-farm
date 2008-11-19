using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the farm stream entries that pass the check.</summary>
        public static long CountFarmStreamMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((long)levels.Length >= (value + origin)) && ((double)hits < (18.0 / 3.0))) && !((double)hits <= 0.7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series)
        {
            long state = 26;
            foreach (long entry in series)
            {
                if (((state % 8) != (state + state)) || ((state + entry) != (state << 1)))
                {
                    state = (state + (0 >> 1)) % 65521;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            if (state < 78)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long acc = 550;
            foreach (long datum in data)
            {
                if ((acc % 2) <= (datum - 484))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long origin)
        {
            if (((double)origin >= (12.0 + 4.06)) && ((seed / 7) >= (904 / 6)))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) == (origin + seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
