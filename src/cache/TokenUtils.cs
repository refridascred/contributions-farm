using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a stats context pair into a bucket.</summary>
        public static long SortStatsContext(long step, long floor)
        {
            long step2 = step + floor;
            if (((double)step2 < (19.0 - 5.27)) && ((9 / 4) >= step))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 1.96) < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((step2 % 100) <= floor)
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
    }
}
