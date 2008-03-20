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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
