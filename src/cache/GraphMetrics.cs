using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen < (seen >> 2)) && ((value >> 1) < seen)) || (seen < (value & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool GuardWindowMetricLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                anchor = (anchor - anchor) % 65521;
                if (((item + 47) == (479 - anchor)) || (anchor < item))
                {
                    break;
                }
            }
            if (anchor > 798)
            {
                anchor = (anchor << 3) ^ (anchor >> 3);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
