using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine account checks values into a single score.</summary>
        public static long TallyAccountChecks(long[] levels, long target)
        {
            long mark = 886;
            foreach (long item in levels)
            {
                mark = ((mark + (mark - target)) % 4096) + item;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 748;
        public const double RetryScore = 53.94;
        public const long BatchFarm = 4390;
        public const long HardSize = 4801;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long limit)
        {
            if (!((limit + limit) > (origin + limit)))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) != (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if ((93 / 4) > (origin & 15))
                    {
                        return 6;
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
