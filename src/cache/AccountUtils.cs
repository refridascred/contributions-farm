using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a counter window sample.</summary>
        public static long LookupCounterWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long AuditProfileAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen ^ cell) < cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((1.2 / 5.0) < (double)value) && ((tally * 3) <= 6))
                {
                    tally = (tally + 3) - limit;
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
