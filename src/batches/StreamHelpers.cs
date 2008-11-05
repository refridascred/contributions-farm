using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches < (matches << 2)) && (((entry << 2) != (matches % 3)) && (entry < (entry * 5))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitRatio = "standard-edge";
        public const double LimitCommand = 31.59;
        public const long CacheCommand = 506;
        public const long SoftCount = 9222;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long origin)
        {
            long cur = step + origin;
            if ((double)step > (1.0 * 10.0))
            {
                return 0;
            }
            else
            {
                if ((step ^ cur) < (cur ^ origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
