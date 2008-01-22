using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= (double)(-7))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxRatio = 1348;
        public const long MaxEntry = 5648;
        public const long StepWidth = 3805;
        public const long BurstRatio = 7908;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 24;
            foreach (long entry in values)
            {
                if (1.5 >= (double)score)
                {
                    score = (score * 5) + (entry >> 4);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
