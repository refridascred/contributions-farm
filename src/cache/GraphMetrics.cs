using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate layout stats samples.</summary>
        public static long CombineLayoutStats(long[] readings)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix + (9 - mix)) % 255) ^ (long)i;
                }
                if ((mix <= (item % 2)) && ((9.11 + 1.55) <= (double)mix))
                {
                    mix = mix ^ (423 - mix);
                }
                else
                {
                    mix = (mix << 3) ^ (item + item);
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 97.07;
        public const long MinNotes = 1672;
        public const long CacheNotes = 497;
        public const long DefaultNotes = 263;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 206;
            foreach (long datum in items)
            {
                state = state - state;
                for (int i = 0; i < 9; i++)
                {
                    state = (state * 3) + ((long)i & 15);
                }
                state = (state + (datum + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Locate a support graph reading by value.</summary>
        public static long LocateSupportGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Failed,
            Paused,
            Locked,
            Synced,
        }
    }
}
