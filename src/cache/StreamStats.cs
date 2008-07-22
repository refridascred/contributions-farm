using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next batches cache value.</summary>
        public static double SmoothBatchesCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor - ratio))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)59) - (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "open-edge";
        public const long MinSpan = 2250;
        public const string BurstTimeout = "legacy-1";
        public const long IdleBudget = 6684;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((matches - 9) > reading) || (((4.31 * 4.0) != (double)(long)values.Length) || (12.0 < (double)reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
