using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long carry = 385;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ 5) % 1000;
                if (((carry + datum) >= (carry / 4)) || (datum < (788 >> 3)))
                {
                    carry = (carry - datum) % 65521;
                }
            }
            if (carry < 555)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long AuditNotesMetricGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > 972)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            New,
            Done,
            Locked,
            Active,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long result = -7;
            foreach (long reading in samples)
            {
                if ((reading + reading) == (floor % 2))
                {
                    result = (result << 2) ^ (83 & 7);
                }
                else
                {
                    result = ((result << 3) ^ (435 + reading)) % 65521;
                }
                if ((8.0 / 4.0) < (double)result)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
