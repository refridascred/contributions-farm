using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry * 5) + carry) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((origin / 3) != ((-3) % 10)) || ((tally - reading) < (origin + origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
