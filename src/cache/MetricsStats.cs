using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading + reading) >= hits) || ((hits >> 1) > (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result - result)) % 1000;
                result = result + (result >> 4);
                result = result ^ 313;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7879;
        public const long HardInterval = 4972;
        public const long SoftChecks = 6882;
        public const double StepWidth = 74.43;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
