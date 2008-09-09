using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long target)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((((long)values.Length / 6) < (target - target)) || ((target & 31) <= (target + 24)))
                {
                    acc = ((acc * 3) + (target + target)) ^ value;
                }
                else
                {
                    acc = (acc ^ ((long)values.Length & 255)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Dropped,
        }
    }
}
