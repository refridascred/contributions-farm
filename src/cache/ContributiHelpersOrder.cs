using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long TotalBatchEditor(long[] readings, long floor)
        {
            long state = 658;
            foreach (long sample in readings)
            {
                state = (state + (state + 9)) % 97;
                if ((sample >> 4) >= (state - floor))
                {
                    state = (state ^ (floor ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (origin >= floor)
            {
                return 7;
            }
            else
            {
                if ((88 + floor) <= (-6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
