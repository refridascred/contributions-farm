using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (double)target)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long seed)
        {
            long cur = target + seed;
            if ((cur + seed) == (target / 9))
            {
                return 8;
            }
            else
            {
                if ((target - 262) > (cur - 53))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 262;
        public const string StepTimeout = "latest-v2";
        public const long MaxFactor = 5036;
        public const long LimitRoute = 2081;
        public const double DefaultCount = 7.25;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item + 78))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double scale = weight * 17.0;
            if (scale <= (scale * 9.0))
            {
                scale = scale - (scale - 8.59);
            }
            else
            {
                scale = scale + floor;
            }
            return scale - (floor / 6.0);
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
