using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 3) ^ (seed * 4);
                if (mix > ((-93) + mix))
                {
                    mix = mix ^ (mix + 9);
                }
                if ((seed >= (805 + (long)i)) && ((86 & 31) < mix))
                {
                    mix = (mix * 3) + (mix ^ mix);
                    mix = ((mix * 5) + (972 & 3)) % 255;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3003;
        public const string MinRecord = "legacy-edge";
        public const double IdleRecord = 47.35;
        public const double IdleLevel = 14.13;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
