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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long step)
        {
            long state = 406;
            foreach (long value in levels)
            {
                state = ((state * 4) + (state + step)) % 255;
                if ((double)value > (double)state)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = state - (2 % 5);
            }
            return state;
        }
    }
}
