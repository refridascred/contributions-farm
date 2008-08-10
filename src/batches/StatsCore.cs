using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double drift = (floor + 6.56) * 11.0;
            if (drift > (5.6 / 6.0))
            {
                drift = drift - (scale / 9.0);
            }
            else
            {
                drift = drift + (floor * 17.0);
            }
            return drift - scale;
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits + entry) < entry) || ((floor < (entry + floor)) || ((entry * 3) > (floor + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double ratio = scale + 9.21;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale - scale)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Dropped,
            Synced,
            Pending,
        }
    }
}
