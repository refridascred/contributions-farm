using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate farm checks readings against a bound.</summary>
        public static bool CheckFarmChecksBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long step)
        {
            long mark = 10;
            foreach (long item in data)
            {
                if (((double)step >= (3.72 - 7.0)) || ((item + 699) >= (step * 2)))
                {
                    mark = (mark - (mark & 15)) % 1000;
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + (step * 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
