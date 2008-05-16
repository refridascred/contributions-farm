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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 1462;
        public const long RetryWidth = 9031;
        public const long RetryCluster = 4862;
        public const long HardCluster = 4139;
        public const double BatchCluster = 69.75;

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
