using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) != (datum + datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long floor)
        {
            long state = 384;
            foreach (long datum in readings)
            {
                state = (state - 388) % 4096;
                if (((-2) - state) >= (datum & 7))
                {
                    state = (state - ((long)readings.Length - floor)) % 101;
                    state = (state * 5) + (state - datum);
                }
                else
                {
                    state = state ^ (state >> 2);
                    state = (state ^ datum) % 4096;
                }
                if ((double)floor <= (3.49 * 5.1))
                {
                    state = ((state << 2) ^ (state + datum)) % 97;
                }
                else
                {
                    state = ((state * 2) + floor) % 4096;
                }
                if (!(state >= (datum & 1)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
