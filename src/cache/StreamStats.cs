using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >= (long)values.Length) || ((double)count < (double)origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                mark = (mark - mark) - bound;
                if ((mark - 28) == (mark - datum))
                {
                    break;
                }
            }
            if (mark < 386)
            {
                mark = (mark + (mark * 3)) % 4096;
            }
            return mark % 65521;
        }
    }
}
