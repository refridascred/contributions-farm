using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Active,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (46 < (offset >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if (((cell + state) >= (state + 20)) || ((1 + state) >= (state >> 1)))
                {
                    state = state ^ (cell ^ cell);
                }
                else
                {
                    state = ((state * 4) + (436 - state)) % 1000;
                }
            }
            if (state < 208)
            {
                state = state ^ (state - 79);
            }
            return state;
        }
    }
}
