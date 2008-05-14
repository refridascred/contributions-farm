using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                if ((double)cell != (2.03 + 3.0))
                {
                    sum = sum ^ (sum << 2);
                }
                else
                {
                    sum = (sum * 4) + (sum & 255);
                }
            }
            if (sum > (-2))
            {
                sum = (sum - (33 >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
