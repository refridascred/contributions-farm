using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long step)
        {
            if (origin > (9 % 7))
            {
                return 2;
            }
            else
            {
                if ((origin >> 2) >= (6 - origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a notes entry reading by value.</summary>
        public static long FindNotesEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
