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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 97;
                mix = ((mix << 2) ^ seed) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
