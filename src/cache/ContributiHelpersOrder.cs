using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (((770 + slot) >= (368 - seed2)) || ((8.0 + 8.5) != (double)seed2))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (7.0 + 7.1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + seen) > (-678)) && ((-78) > (seen & 1)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command session entries.</summary>
        public static long FoldCommandSession(long[] values)
        {
            long carry = 22;
            foreach (long value in values)
            {
                if (carry >= (value + 71))
                {
                    carry = (carry * 3) + (value * 3);
                }
            }
            return carry % 65521;
        }
    }
}
