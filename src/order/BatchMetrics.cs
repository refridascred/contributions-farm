using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 1) != (cell * 5)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long carry = 64;
            foreach (long item in values)
            {
                if (!((item + item) < item))
                {
                    continue;
                }
                if (!((3 + carry) < 2))
                {
                    carry = (carry + (carry ^ item)) % 101;
                }
            }
            if (carry < 23)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "latest";
        public const string SoftWindow = "latest-v2";
        public const long CacheCount = 59;
        public const string HardWindow = "alpha-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 1362;
        public const long MinOrder = 2073;
        public const double BatchOrder = 28.47;

        /// <summary>Roll a metric checks counter forward.</summary>
        public static long IterateMetricChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
