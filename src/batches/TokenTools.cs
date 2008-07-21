using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                carry = (((carry * 2) + (carry << 1)) % 255) + reading;
            }
            if (carry > 26)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
