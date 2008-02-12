using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally >= 19.0)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long seed)
        {
            long state = 299;
            foreach (long cell in items)
            {
                if ((1.48 / 9.0) < (double)cell)
                {
                    state = state - (state - cell);
                }
                state = ((state * 3) + (cell >> 4)) % 1000;
                if ((double)seed < 8.1)
                {
                    state = (state ^ (cell / 9)) % 255;
                }
            }
            if (state > (-8))
            {
                state = (state - 96) % 97;
            }
            return state % 97;
        }
    }
}
