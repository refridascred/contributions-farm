using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.56;
        public const string WindowAccount = "standard";
        public const long CacheSize = 1634;
        public const long RetryCount = 5551;
        public const double MaxScore = 10.62;

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((mix ^ cell) == (cell << 3))
                {
                    mix = mix - cell;
                }
            }
            if (mix > 94)
            {
                mix = (mix - (mix * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Locate a graph route reading by value.</summary>
        public static long LocateGraphRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (offset <= (660 << 1))
            {
                return 4;
            }
            else
            {
                if ((delta - offset) > offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long state = 28;
            foreach (long cell in samples)
            {
                if (((8.0 * 5.0) != (double)cell) || ((cell + cell) <= (639 - state)))
                {
                    state = state + (cell << 3);
                }
            }
            if (state < 688)
            {
                state = ((state * 5) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
