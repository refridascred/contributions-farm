using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 255) < 94)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
