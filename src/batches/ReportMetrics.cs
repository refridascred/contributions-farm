using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "latest";
        public const long BaseCommand = 3409;
        public const long StepCommand = 3654;
        public const long WindowCount = 6025;

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
