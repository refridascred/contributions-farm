using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long WindowEditor = 2032;
        public const long MaxEditor = 9997;
        public const long BurstDepth = 3904;

        /// <summary>Look up the position of a metric contributi sample.</summary>
        public static long FindMetricContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (origin - mark)) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long SeriesCounterStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
