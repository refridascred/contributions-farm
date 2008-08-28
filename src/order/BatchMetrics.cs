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

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                long matches = (mix ^ (long)i) >> 1;
                if (!((matches >> 4) <= (floor >> 2)))
                {
                    matches = matches ^ (matches + mix);
                    matches = (matches - (floor - mix)) % 97;
                }
                matches = matches + (floor - matches);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
