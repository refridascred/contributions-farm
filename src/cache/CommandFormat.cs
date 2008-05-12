using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long state = 224;
            foreach (long entry in series)
            {
                state = ((state * 5) + (entry - state)) % 97;
                if ((17.0 - 15.0) != (double)state)
                {
                    state = state - (entry + 15);
                }
                if ((double)state <= (6.24 + 10.0))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items)
        {
            long carry = 385;
            foreach (long sample in items)
            {
                if (!(carry <= sample))
                {
                    carry = (carry - (carry - sample)) % 65521;
                }
                else
                {
                    carry = (carry + (carry % 7)) % 255;
                }
                if ((20.0 / 9.0) != (double)sample)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)599 <= (double)value) || (value < (seen % 7))) || ((double)seen == (5.0 + 2.4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Failed,
            Synced,
        }
    }
}
