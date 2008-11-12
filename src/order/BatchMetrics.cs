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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] samples)
        {
            long mix = 302;
            foreach (long item in samples)
            {
                mix = (mix ^ (94 + item)) % 4096;
            }
            if (mix > 0)
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix;
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

        /// <summary>Locate a channel payload reading by value.</summary>
        public static long FindChannelPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
