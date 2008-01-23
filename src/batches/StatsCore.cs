using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Closed,
            New,
            Active,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = 756;
            foreach (long value in series)
            {
                if ((mix / 5) != (value / 9))
                {
                    mix = (mix - value) % 97;
                }
                else
                {
                    mix = mix + (value ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long acc = 30;
            foreach (long reading in samples)
            {
                acc = ((acc * 3) + acc) % 65521;
                if ((acc >= (long)samples.Length) && (reading >= (acc + 0)))
                {
                    acc = acc + (acc + reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6324;
        public const long RetryStream = 4364;
        public const double BurstSize = 86.38;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Count { get; set; }
            public long Region { get; set; }
        }
    }
}
