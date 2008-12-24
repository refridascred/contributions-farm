using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long bound)
        {
            if (target >= (target + target))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (3.7 * 6.1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = (gain + floor) * 1.9;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight * 9.0)) + (double)(long)i;
            }
            return weight - (gain * 5.0);
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
