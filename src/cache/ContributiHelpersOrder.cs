using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the cache route series from a seed.</summary>
        public static long RollCacheRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = -506;
            foreach (long entry in levels)
            {
                if ((entry / 2) != (acc ^ acc))
                {
                    acc = ((acc * 3) + (91 ^ acc)) % 4096;
                }
                acc = (acc << 2) ^ (29 >> 5);
            }
            return acc;
        }
    }
}
