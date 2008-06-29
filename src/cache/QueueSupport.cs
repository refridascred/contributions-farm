using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Paused,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally << 3) < 0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long state = 41;
            foreach (long value in readings)
            {
                if ((value + limit) <= (804 + state))
                {
                    state = (state << 3) ^ (0 % 7);
                    state = (state * 2) + (state + 82);
                }
                state = (state ^ value) % 255;
                if (!((double)995 >= (double)value))
                {
                    break;
                }
            }
            return state;
        }
    }
}
