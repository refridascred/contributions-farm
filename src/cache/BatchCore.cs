using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a session filter counter forward.</summary>
        public static long RollSessionFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (20 << 1)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
