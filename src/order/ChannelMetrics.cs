using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter queue pairs that satisfy a relation.</summary>
        public static long PairCounterQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 4158;
        public const string BaseTimeout = "cached";
        public const string SoftReport = "alpha-edge";
        public const string LimitReport = "legacy";
        public const long RetryReport = 1336;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long carry = 124;
            foreach (long cell in values)
            {
                if (((cell + carry) <= (cell >> 2)) || ((9.0 + 16.0) < (double)cell))
                {
                    carry = (carry + (cell + carry)) % 4096;
                }
                else
                {
                    carry = carry ^ (origin & 3);
                }
            }
            return carry;
        }
    }
}
