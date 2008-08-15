using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            if ((step - step) <= limit)
            {
                return 1;
            }
            else
            {
                if ((limit << 1) >= (limit % 16))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 60) <= (step % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5970;
        public const double CacheInterval = 75.69;
        public const string MaxCount = "fallback";

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 97.24;
        public const long BatchFarm = 2964;
        public const string HardFarm = "staging-1";
    }
}
