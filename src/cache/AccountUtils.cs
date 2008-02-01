using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long AuditCounterSupportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell < (6.0 / 2.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 2) <= (reading + seen))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
