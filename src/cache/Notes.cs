using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long origin)
        {
            long acc = 569;
            foreach (long entry in samples)
            {
                if ((acc % 100) >= (0 + acc))
                {
                    acc = (((acc * 3) + (acc ^ origin)) % 1000) ^ entry;
                }
                else
                {
                    acc = (acc << 3) ^ (origin >> 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long state = 78;
            foreach (long cell in values)
            {
                if ((cell >= (floor * 3)) || ((11.0 * 9.8) == (double)floor))
                {
                    state = (state - (cell ^ floor)) % 101;
                }
            }
            if (state < 68)
            {
                state = state + (floor + state);
            }
            return state;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi account entry that matches the target.</summary>
        public static long SeekContributiAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
