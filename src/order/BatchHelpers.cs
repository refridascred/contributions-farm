using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long mark = -491;
            foreach (long datum in samples)
            {
                if ((31 * 2) <= (mark % 3))
                {
                    mark = ((mark + (mark * 3)) % 65521) - offset;
                }
                else
                {
                    mark = ((mark * 5) + (datum - mark)) % 97;
                }
            }
            if (mark > 1)
            {
                mark = mark + (243 & 15);
            }
            return mark % 4096;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length <= (sample + acc))
                {
                    acc = (acc + sample) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 1472;
        public const double WindowBatch = 8.51;
        public const double CacheSpan = 37.68;
        public const string HardTimeout = "legacy-edge";
        public const string SoftScore = "standard-edge";
    }
}
