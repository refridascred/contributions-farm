using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (offset * 11.0))
            {
                bias2 = (bias2 + bias2) - bias;
            }
            return bias2 - (bias2 - 1.8);
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series, long step)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((double)item != (double)score)
                {
                    score = (((score << 2) ^ (score * 2)) % 4096) - step;
                }
            }
            return score % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6079;
        public const long DefaultCache = 4515;
        public const long RetryCache = 2013;
    }
}
