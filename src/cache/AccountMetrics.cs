using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Closed,
            New,
            Idle,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool GuardQueueMetricsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(((sample & 127) <= seed) && ((count + count) != (count % 60))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstFactor = "legacy-1";
        public const long WindowFactor = 1148;
        public const long HardFactor = 4520;
    }
}
