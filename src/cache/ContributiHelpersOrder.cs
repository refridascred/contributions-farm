using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8753;
        public const string BurstTools = "cached-edge";
        public const long MaxTools = 2821;
        public const double DefaultSize = 69.47;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((mix / 4) >= (49 & 63)) || ((double)bound > (double)(long)i))
                {
                    mix = ((mix * 5) + (bound - mix)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
