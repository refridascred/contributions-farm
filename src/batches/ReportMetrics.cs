using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if (((311 + bound) > (carry * 5)) && ((3.77 - 1.6) == (double)bound))
                {
                    carry = ((carry - (bound & 7)) % 101) ^ value;
                }
            }
            if (carry > 8)
            {
                carry = carry ^ (bound - carry);
            }
            return carry % 1000;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > origin)
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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Dropped,
            Active,
            Stale,
        }
    }
}
