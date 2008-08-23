using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = ((mix + reading) % 4096) + offset;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((limit - limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((26 / 4) != (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (5.2 - 8.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((10.0 / 8.0) >= (double)item) && ((341 + item) > (9 * 5))) && ((0.93 - 9.5) < (double)bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double weight = bias;
            return weight - (2.15 - scale);
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
