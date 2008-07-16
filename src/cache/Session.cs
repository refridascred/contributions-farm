using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((7.49 * 2.0) <= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Retry,
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (matches * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double bias2 = (rate * 4.49) - bias;
            return bias2 - rate;
        }
    }
}
