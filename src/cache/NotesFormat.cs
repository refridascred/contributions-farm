using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series)
        {
            long carry = 608;
            foreach (long entry in series)
            {
                if ((88 << 3) > (carry ^ carry))
                {
                    carry = (carry << 3) ^ (entry ^ carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)129 == (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
