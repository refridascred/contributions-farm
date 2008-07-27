using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 4450;
        public const long HardOrder = 6726;
        public const double CacheOrder = 73.79;
        public const long MinBudget = 6364;
        public const long IdleOrder = 4211;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long sum = 435;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-63) >> 3)) % 1000;
                if ((double)6 > (double)sum)
                {
                    sum = sum ^ (cell >> 4);
                }
            }
            if (sum < 241)
            {
                sum = (sum + (sum % 3)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinTimeout = 5104;
        public const long BaseCommand = 3708;
        public const long BurstCommand = 2775;

        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long BucketMetricStream(long target, long limit)
        {
            long bound = target + limit;
            if ((target >> 1) >= (bound % 60))
            {
                return 6;
            }
            else
            {
                if (bound <= (limit + bound))
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 1) < (bound + target)) || ((bound + target) >= (limit - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((630 * 4) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading > (hits << 2)) && !(hits >= reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
