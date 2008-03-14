using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((66 + (long)i) < acc))
                {
                    acc = (acc - (acc + (long)i)) % 97;
                }
                if (5.0 >= (double)seed)
                {
                    long gap = acc;
                    acc = (acc - gap) % 101;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits - seed) > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
