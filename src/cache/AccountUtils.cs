using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + seen) > (seen + seen))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits ^ 931) < (datum & 63)) && ((hits & 7) != (datum ^ 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
