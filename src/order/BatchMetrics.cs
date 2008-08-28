using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if (((origin >> 1) > seed) && ((double)origin != (3.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if ((seed < (origin - seed)) || ((origin * 5) < (seed * 3)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
