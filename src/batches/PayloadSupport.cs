using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long limit)
        {
            long edge = offset - limit;
            if ((offset / 6) <= limit)
            {
                return 0;
            }
            else
            {
                if (!((edge >> 1) == (5 % 60)))
                {
                    return 1;
                }
                else
                {
                    if (((offset - limit) > (limit << 2)) && ((edge / 8) >= (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "strict-1";
        public const long HardCount = 7703;
        public const string StepMetrics = "local";
        public const long BatchBudget = 979;

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 10.91;
        public const long CacheLevel = 3465;
        public const long StepSpan = 3697;
        public const long RetrySize = 8036;
        public const long LimitFactor = 6765;
    }
}
