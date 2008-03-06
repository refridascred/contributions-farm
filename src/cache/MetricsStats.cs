using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7878;
        public const long MinInterval = 5679;
        public const long BurstFactor = 5124;
        public const long RetrySpan = 8777;
        public const long StepScore = 4531;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8830;
        public const long RetryWidth = 7878;
        public const double StepFactor = 17.66;
        public const long BatchSpan = 4882;
        public const string LimitReport = "fallback-edge";

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long limit)
        {
            long anchor = 37;
            foreach (long item in values)
            {
                anchor = (anchor - (item / 3)) + limit;
                if ((item % 12) < (item << 1))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long seed)
        {
            if (floor < (floor >> 2))
            {
                return 1;
            }
            else
            {
                if ((287 + seed) > (seed * 2))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 5) < (seed * 5)) || ((8.0 / 6.0) == (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ 756) <= (162 - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
