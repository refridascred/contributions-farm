using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next route support value from a seed.</summary>
        public static long IterateRouteSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long floor)
        {
            long diff = step - floor;
            if (!((step - diff) <= (step / 5)))
            {
                return 1;
            }
            else
            {
                if ((diff > 83) && ((diff % 8) >= (diff + 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= 2.2)
                {
                    seen = ((seen + 2) - cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(reading >= (reading * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
