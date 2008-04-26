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

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long floor)
        {
            long sum = 632;
            foreach (long reading in items)
            {
                if ((floor - floor) < (floor % 5))
                {
                    sum = ((sum - floor) % 1000) ^ reading;
                }
            }
            return sum % 4096;
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

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 6092;
        public const string IdleToken = "fallback";
        public const long BaseTimeout = 9277;
        public const long CacheToken = 6213;
    }
}
