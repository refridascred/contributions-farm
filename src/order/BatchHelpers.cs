using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 986;
            foreach (long item in series)
            {
                if (384 >= (item / 7))
                {
                    mark = mark - 3;
                }
                else
                {
                    mark = mark + item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + hits) > 9)
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 6346;
        public const double DefaultScore = 65.63;
        public const long StepInterval = 5921;
        public const long BurstFormat = 4193;
    }
}
