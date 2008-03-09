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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
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
