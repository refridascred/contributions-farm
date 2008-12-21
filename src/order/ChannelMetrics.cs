using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of profile schema readings.</summary>
        public static long CombineProfileSchema(long[] levels)
        {
            long mark = 30;
            foreach (long cell in levels)
            {
                mark = (mark - ((-62) & 127)) - cell;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long floor)
        {
            if (!((step - floor) != (985 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) != (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 2) <= 5)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
