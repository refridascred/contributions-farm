using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (matches / 6))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) != (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
