using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 9017;
        public const long MaxDepth = 6734;
        public const long MaxPayload = 329;
        public const long CacheFactor = 4888;
        public const long BurstSpan = 5700;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum & 1) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
