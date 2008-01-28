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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
