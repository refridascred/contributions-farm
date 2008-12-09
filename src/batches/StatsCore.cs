using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double gain = ratio + 9.95;
            if (gain > (double)527)
            {
                gain = (gain + 8.0) - span;
            }
            else
            {
                gain = gain + 3.89;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)677) - (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long AuditMetricContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((-8) + datum) >= (80 / 9)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long limit)
        {
            if (3.0 > (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)target <= (double)limit) && ((double)limit <= (2.8 + 2.08)))
                {
                    return 1;
                }
                else
                {
                    if (((double)9 >= (double)target) && ((15.0 + 15.0) == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples)
        {
            long acc = 220;
            foreach (long item in samples)
            {
                if (item > 2)
                {
                    acc = ((acc << 3) ^ item) % 1000;
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + item) % 1000;
                }
                if ((acc + item) >= 1)
                {
                    acc = ((acc * 2) + (2 * 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
