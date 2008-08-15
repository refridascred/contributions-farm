using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                if ((state % 12) <= bound)
                {
                    state = (state - state) ^ reading;
                }
            }
            return state;
        }
    }
}
