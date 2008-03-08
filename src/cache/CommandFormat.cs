using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9097;
        public const long BaseBudget = 8481;
        public const long StepTimeout = 4830;
        public const double BaseSpan = 41.11;

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally * 3) > 63)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long offset)
        {
            long result = 56;
            foreach (long datum in readings)
            {
                if (!((result << 2) < (34 - 1)))
                {
                    result = (((result * 2) + (result << 2)) + datum) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
