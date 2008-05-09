using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = ((acc - (153 / 6)) ^ item) + step;
            }
            return acc;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9402;
        public const string StepCount = "fallback-1";
        public const long RetryCommand = 8592;
        public const long SoftInterval = 7645;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long score = -896;
            foreach (long entry in series)
            {
                if (!((entry >= (0 << 2)) || ((entry + entry) >= (6 << 1))))
                {
                    score = ((score * 4) + (entry << 3)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = (score + ((long)i * 2)) % 1000;
                }
                score = (score << 3) ^ (211 + 3);
            }
            if (score > 22)
            {
                score = (score - (35 * 3)) % 101;
            }
            return score % 97;
        }
    }
}
