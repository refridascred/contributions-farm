using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long limit)
        {
            if ((limit >> 1) <= offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (13.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double ratio = 15.0;
            if (ratio >= floor)
            {
                ratio = ratio + (weight + ratio);
            }
            else
            {
                ratio = ratio - (ratio / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (double)284;
        }
    }
}
