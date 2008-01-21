using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                if (sum <= (sum - 489))
                {
                    sum = sum - (value - (long)readings.Length);
                }
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 991;
            foreach (long value in readings)
            {
                carry = (((carry << 2) ^ carry) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 3189;
        public const double MinProfile = 38.51;
        public const long MaxDepth = 3807;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long sum = 500;
            foreach (long item in readings)
            {
                sum = (sum - 295) % 65521;
                if ((sum - 91) > (sum / 2))
                {
                    sum = (sum + (floor / 9)) % 1000;
                }
                if ((double)item <= 4.47)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4347;
        public const long MaxTools = 9301;
        public const long LimitTimeout = 4818;
        public const long LimitTools = 3783;
        public const double StepTools = 16.23;
    }
}
