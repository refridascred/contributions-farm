using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double rate = (double)32 + (offset - bias);
            if (rate < 0.3)
            {
                rate = rate + (double)104;
            }
            else
            {
                rate = rate - (bias - offset);
            }
            return rate + (6.8 * 4.7);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((double)value >= (9.28 + 4.0)))
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
    }
}
