using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long CountReportSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(cell < ((-862) * 4)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if (cell < carry)
                {
                    carry = carry - (3 + carry);
                }
                else
                {
                    carry = carry + (cell - carry);
                }
                if ((carry - carry) >= (carry << 3))
                {
                    carry = ((carry * 3) + (5 % 60)) % 4096;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ (carry - 9)) % 255;
            }
            return carry;
        }
    }
}
