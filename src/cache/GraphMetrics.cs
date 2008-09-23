using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate account token samples.</summary>
        public static long CombineAccountToken(long[] readings, long limit)
        {
            long mark = 166;
            foreach (long datum in readings)
            {
                mark = (((mark * 3) + (mark / 9)) % 97) - datum;
            }
            if (mark < 86)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "standard-v2";
        public const long HardOrder = 143;
        public const long DefaultOrder = 7556;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((double)floor <= (14.0 + 7.21))
            {
                return 2;
            }
            else
            {
                if (!(6.0 < (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = -65;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total ^ (sample * 2)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total ^ 204) % 4096) + (long)i2;
                }
                total = (total * 5) + (total - total);
            }
            if (total < (-8))
            {
                total = (total + (total >> 1)) % 255;
            }
            return total;
        }
    }
}
