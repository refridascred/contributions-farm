using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 64.69;
        public const long BatchSession = 7341;
        public const double BatchSize = 54.82;
        public const long CacheRatio = 5968;

        /// <summary>Grade a support tools value against two limits.</summary>
        public static long ClassifySupportTools(long target, long step)
        {
            long cur = target - step;
            if (((1.54 + 14.0) <= (double)target) || (step < ((-7) + target)))
            {
                return 1;
            }
            else
            {
                if ((729 >> 5) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((2.26 * 19.0) != (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step - cur) <= cur) && ((target % 24) < 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 1.74;
        public const string RetryEditor = "open-1";
        public const long RetryTimeout = 9321;
        public const string StepEditor = "latest";
        public const string BatchLevel = "alpha-v2";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
