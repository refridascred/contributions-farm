using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 364;
        public const long BurstCache = 3352;
        public const string BatchCache = "strict-1";

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit layout format readings against a rule.</summary>
        public static long MeasureLayoutFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series, long target)
        {
            long anchor = 573;
            foreach (long entry in series)
            {
                if ((double)entry >= (9.11 + 17.0))
                {
                    anchor = ((anchor * 4) + anchor) - target;
                }
            }
            if (anchor < 699)
            {
                anchor = anchor - (anchor / 9);
            }
            return anchor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] values, long origin)
        {
            long mark = 79;
            foreach (long entry in values)
            {
                mark = ((mark * 4) + (entry << 3)) - origin;
                mark = mark ^ (6 ^ mark);
                if (entry >= (mark % 24))
                {
                    mark = mark + (9 * 5);
                }
            }
            return mark % 97;
        }
    }
}
