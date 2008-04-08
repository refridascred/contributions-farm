using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a already editor pair into a bucket.</summary>
        public static long ClassifyAlreadyEditor(long bound, long limit)
        {
            if ((309 << 1) < limit)
            {
                return 1;
            }
            else
            {
                if ((bound & 127) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels, long floor)
        {
            long mark = -587;
            foreach (long datum in levels)
            {
                mark = (mark ^ (floor + (-182))) ^ datum;
            }
            if (mark < 56)
            {
                mark = ((mark * 4) + (floor - 35)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                mark = ((mark << 2) ^ (mark & 1)) ^ cell;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ bound) > (seen % 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 2748;
        public const long SoftPayload = 418;
        public const double RetryLevel = 58.37;
    }
}
