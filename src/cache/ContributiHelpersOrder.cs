using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long anchor = 797;
            foreach (long datum in items)
            {
                anchor = (anchor - floor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 3) + (seed / 9);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
