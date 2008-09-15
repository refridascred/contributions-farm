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

        /// <summary>Iterate the account record series from a seed.</summary>
        public static long RollAccountRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - sum;
                if (!(origin < (origin - 39)))
                {
                    sum = ((sum * 2) + (origin ^ sum)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
