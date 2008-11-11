using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate payload cluster samples.</summary>
        public static long WeighPayloadCluster(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ origin) - value;
            }
            if (sum > 346)
            {
                sum = (sum * 4) + ((long)samples.Length << 2);
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target % 97) == (value ^ value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of context support readings.</summary>
        public static long OverlapContextSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
