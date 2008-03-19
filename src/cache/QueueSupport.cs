using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next stream already value from a seed.</summary>
        public static long SeriesStreamAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (target >= (46 + 92))
                {
                    mark = mark + 89;
                    mark = ((mark << 3) ^ (975 + mark)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 50;
            foreach (long entry in items)
            {
                acc = (acc - (entry + entry)) % 1000;
                acc = (acc - (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) != (1 + 6))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
