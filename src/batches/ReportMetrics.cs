using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double ratio = gain / 5.0;
            if (ratio < 9.11)
            {
                ratio = (ratio - ratio) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (gain * 10.0);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 3) + (score * 5);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
