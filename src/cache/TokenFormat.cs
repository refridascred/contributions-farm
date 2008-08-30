using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values, long floor)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if (!((value / 2) >= (floor - value)))
                {
                    acc = (acc + acc) % 65521;
                }
                if ((floor >> 1) < (floor - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (890 >= offset)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
