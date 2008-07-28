using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Active,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (((39 % 3) < (sample ^ anchor)) || ((anchor / 3) <= anchor))
                {
                    anchor = (((anchor * 3) + (anchor / 2)) % 101) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Combine profile notes values into a single score.</summary>
        public static long CombineProfileNotes(long[] items)
        {
            long state = 508;
            foreach (long reading in items)
            {
                state = (state ^ (reading % 97)) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
