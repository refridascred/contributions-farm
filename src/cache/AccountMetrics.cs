using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Ready,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Roll a route metrics counter forward.</summary>
        public static long RollRouteMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5669;
        public const double MinTimeout = 35.67;
        public const long CacheSchema = 196;
        public const long CacheBudget = 355;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (acc >> 2) / 7;
                if (slot <= (slot + slot))
                {
                    acc = acc + (acc ^ (long)i);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
