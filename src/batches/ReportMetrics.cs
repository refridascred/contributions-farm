using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long LookupFarmProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < 211)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                if ((double)cell < (6.3 * 6.41))
                {
                    carry = ((carry << 3) ^ (cell >> 2)) % 101;
                    break;
                }
                carry = ((carry * 3) + cell) % 101;
                carry = (carry + (carry ^ carry)) % 65521;
            }
            return carry;
        }
    }
}
