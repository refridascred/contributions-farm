using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long origin)
        {
            if ((floor <= origin) && ((floor << 2) > (origin + 163)))
            {
                return 8;
            }
            else
            {
                if ((floor + origin) >= (origin * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double drift = 3.6;
            if (drift < (drift * 3.85))
            {
                drift = ((drift + drift) - gain) - floor;
            }
            return drift - (3.0 - drift);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (offset > (tally + offset))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits < (3.0 * 1.27))
                {
                    hits = ((hits + 2) ^ cell) + limit;
                }
            }
            return hits;
        }
    }
}
