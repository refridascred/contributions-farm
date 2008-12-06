using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long CountAlreadyBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long sum = 81;
            foreach (long value in items)
            {
                if (!(origin < (sum + origin)))
                {
                    sum = ((sum * 4) + sum) - value;
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }
    }
}
