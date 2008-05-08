using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long target)
        {
            long delta = step + target;
            if ((delta + delta) > step)
            {
                return 5;
            }
            else
            {
                if (step > (target - target))
                {
                    return 8;
                }
                else
                {
                    if (((9 << 3) != (target - step)) && (306 < (step + 56)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 6.12;
        public const long StepInterval = 2923;
        public const long BatchFormat = 3238;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
