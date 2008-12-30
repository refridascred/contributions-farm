using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long total = -6;
            foreach (long item in readings)
            {
                if ((bound + item) < bound)
                {
                    total = (total ^ (item & 1)) % 65521;
                }
            }
            if (total > 125)
            {
                total = (total * 5) + (total + bound);
            }
            return total;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long StepSupportNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (seed << 2)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
