using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                if ((837 + datum) != (3 * 2))
                {
                    state = ((state * 2) + (datum + 8)) % 1000;
                }
                state = state - datum;
                if (!((datum - state) >= state))
                {
                    state = (state ^ 7) % 4096;
                }
                else
                {
                    state = (state + datum) % 97;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 456;
        public const string HardSpan = "alpha-1";
        public const long MinNotes = 9318;
        public const long BurstFactor = 7362;

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double gain = bias * 8.0;
            if (gain < bias)
            {
                gain = gain - (scale * 5.2);
            }
            else
            {
                gain = gain + bias;
            }
            return gain - (9.0 / 9.0);
        }
    }
}
