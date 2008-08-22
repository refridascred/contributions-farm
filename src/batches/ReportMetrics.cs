using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
