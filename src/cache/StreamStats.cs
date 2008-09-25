using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 958;
            foreach (long sample in readings)
            {
                if (589 < (sample + (long)readings.Length))
                {
                    score = (score << 3) ^ score;
                    continue;
                }
                score = (score - (9 - sample)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits & 31) != (value + value))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double mean = (double)((-4) & 63);
            if (mean > (bias + scale))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
