using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long MeasureCommandCommitsOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length != (2.0 / 6.0))
                {
                    hits = ((hits + 2) ^ entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long CountStreamFarmOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits << 3) >= 4) || ((0 & 255) <= (value + value)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
