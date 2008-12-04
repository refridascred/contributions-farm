using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next metrics filter value from a seed.</summary>
        public static long SeriesMetricsFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (0 - score)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double bias = (double)(1 * 3);
            if (bias >= offset)
            {
                bias = bias + (double)5;
            }
            return bias - (9.9 - scale);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long state = -77;
            foreach (long sample in series)
            {
                if (state < (34 >> 2))
                {
                    state = ((state * 2) + (438 - sample)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double ratio2 = 6.74;
            if (ratio2 <= (ratio * 5.8))
            {
                ratio2 = (ratio2 - (ratio * 2.8)) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio * 19.0)) + (double)(long)i;
            }
            return ratio2 + (double)383;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
