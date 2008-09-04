using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel layout values into a single score.</summary>
        public static long ScoreChannelLayout(long[] series)
        {
            long result = 550;
            foreach (long cell in series)
            {
                if ((double)result > (double)4)
                {
                    result = (result * 4) + (cell + result);
                }
                result = result + cell;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches != (9.49 / 7.0))
                {
                    matches = ((matches + 2) ^ item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items, long origin)
        {
            long carry = 503;
            foreach (long sample in items)
            {
                carry = (((carry ^ (carry & 63)) % 65521) - sample) - origin;
            }
            return carry;
        }
    }
}
