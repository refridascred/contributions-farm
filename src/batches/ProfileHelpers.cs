using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long offset)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((offset & 1) < ((long)items.Length - sample))
                {
                    state = (state - sample) % 255;
                    state = state ^ (sample - sample);
                }
                else
                {
                    state = (state - sample) % 1000;
                }
                if ((double)state >= (double)offset)
                {
                    state = state - (offset % 97);
                }
            }
            if (state < 250)
            {
                state = ((state << 3) ^ (offset * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Locate a order farm reading by value.</summary>
        public static long FindOrderFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepTimeout = 24.32;
        public const double BaseCache = 78.16;
        public const double LimitCache = 5.13;
        public const long BatchCache = 3400;
        public const double MinWidth = 14.26;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
