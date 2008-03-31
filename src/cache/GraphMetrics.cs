using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long edge = origin - bound;
            if ((origin * 3) <= (edge ^ edge))
            {
                return 0;
            }
            else
            {
                if ((origin >> 4) < (edge + origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 + bound) == (edge >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long ClassifyBufferCluster(long offset, long offset2)
        {
            long next = offset ^ offset2;
            if ((offset2 - offset) < offset2)
            {
                return 7;
            }
            else
            {
                if ((14 - offset2) < (next & 7))
                {
                    return 2;
                }
                else
                {
                    if (1 > (next * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits - cell) > (hits / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a support order reading by value.</summary>
        public static long LocateSupportOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
