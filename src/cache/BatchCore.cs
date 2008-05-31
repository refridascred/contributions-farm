using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2912;
        public const double BurstLayout = 7.12;
        public const double HardLayout = 37.17;
        public const string WindowFactor = "strict-1";
        public const long BatchLayout = 7903;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((3 + hits) >= reading) || (offset >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long gap = offset + origin;
            if (!(offset > (gap ^ gap)))
            {
                return 7;
            }
            else
            {
                if ((gap * 5) != (gap >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (1.0 - 9.44))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
