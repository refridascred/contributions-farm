using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of support filter entries.</summary>
        public static long TotalSupportFilter(long[] readings)
        {
            long acc = 18;
            foreach (long entry in readings)
            {
                if (!((entry & 1) == (entry << 3)))
                {
                    continue;
                }
                acc = ((acc * 4) + (acc >> 3)) % 65521;
                if ((double)entry != (13.0 / 9.0))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = ((acc * 5) + acc) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 4;
            foreach (long value in levels)
            {
                state = (state - (state + state)) % 65521;
                if ((value < (value * 3)) || ((88 % 5) > (state + state)))
                {
                    state = (state + (value / 7)) % 65521;
                }
            }
            return state;
        }
    }
}
