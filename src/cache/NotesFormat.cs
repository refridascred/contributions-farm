using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 535;
            foreach (long datum in values)
            {
                if (!((1.2 > (double)datum) && ((850 + datum) >= 8)))
                {
                    mix = mix + (mix + 2);
                }
                if ((mix + datum) <= (mix ^ datum))
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2573;
        public const long DefaultToken = 3017;
        public const double BaseToken = 78.44;
        public const string SoftToken = "staging-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long state = 603;
            foreach (long reading in levels)
            {
                state = ((state * 5) + (reading << 1)) % 101;
                if (!((bound - state) > (state + bound)))
                {
                    state = state - bound;
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
        }
    }
}
