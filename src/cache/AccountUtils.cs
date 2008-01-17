using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ tally) > (reading - reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((510 >> 2) != (value + 12))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
