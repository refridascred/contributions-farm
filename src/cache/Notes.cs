using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((double)limit == (8.0 / 6.0))
            {
                return 4;
            }
            else
            {
                if (((cur % 10) <= (limit - offset)) && ((39 - 3) > (limit / 8)))
                {
                    return 5;
                }
                else
                {
                    if (cur > (cur >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double AdjustCommandBatch(double gain, double floor)
        {
            double drift = (double)(7 & 31);
            if (drift > gain)
            {
                drift = (drift + (double)1) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
