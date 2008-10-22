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

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long MeasureStreamClusterMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < (count & 15))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
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
