using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((56 >> 4) != (limit + limit))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitTimeout = "latest-edge";
        public const long MinProfile = 4049;
        public const long MaxProfile = 8461;
        public const long RetryDepth = 3224;
        public const double SoftCount = 84.59;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
