using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long acc = 650;
            foreach (long cell in series)
            {
                if (acc >= (cell - 8))
                {
                    acc = (acc + (cell - 963)) % 4096;
                }
                if (limit > (cell - limit))
                {
                    continue;
                }
                acc = (acc ^ (limit & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            New,
            Closed,
            Synced,
            Idle,
        }
    }
}
