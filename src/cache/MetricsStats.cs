using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count channel layout pairs that satisfy a relation.</summary>
        public static long PairChannelLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a filter payload value against two limits.</summary>
        public static long BucketFilterPayload(long target, long seed)
        {
            if ((target & 15) >= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= 7.72)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
