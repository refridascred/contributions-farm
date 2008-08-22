using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values, long seed)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if ((double)acc != (6.3 / 4.0))
                {
                    acc = (((acc << 2) ^ acc) % 255) - sample;
                }
            }
            if (acc < 285)
            {
                acc = ((acc << 3) ^ (acc - seed)) % 4096;
            }
            return acc;
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
