using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)55 > 3.0) && ((1.0 / 7.0) <= (double)item)) && ((tally <= (item - origin)) || ((1.51 + 3.0) <= (double)origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (380 - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >> 4) < offset)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
