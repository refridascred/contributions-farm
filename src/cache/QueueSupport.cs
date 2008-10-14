using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 6216;
        public const double StepCount = 12.81;
        public const string StepStream = "legacy-1";
        public const double RetryFactor = 43.48;
        public const long MaxInterval = 7067;

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                if ((double)floor != (3.9 - 5.0))
                {
                    carry = ((carry << 2) ^ (carry << 2)) + value;
                }
                else
                {
                    carry = (carry << 2) ^ (carry + floor);
                }
            }
            if (carry < 809)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 65521;
        }
    }
}
