using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9188;
        public const long BatchMetric = 9675;
        public const string WindowMetric = "strict-edge";

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long sum = 492;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (floor / 3))
                {
                    sum = sum - 72;
                }
                if (((floor - 698) > (floor ^ value)) || (floor <= (floor << 1)))
                {
                    sum = sum ^ 81;
                }
            }
            if (sum < 39)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((bound * 3) < (item % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
