using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record already entries.</summary>
        public static long FoldRecordAlready(long[] items)
        {
            long sum = 17;
            foreach (long datum in items)
            {
                if ((sum + (long)items.Length) > sum)
                {
                    sum = (sum ^ (21 << 1)) % 97;
                }
                else
                {
                    sum = (sum ^ datum) % 65521;
                }
            }
            if (sum > 0)
            {
                sum = sum - ((long)items.Length - sum);
            }
            return sum;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
