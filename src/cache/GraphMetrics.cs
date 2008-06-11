using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double scale = (weight + weight) - (span - span);
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 80.32;
        public const double BatchCache = 95.52;
        public const long CacheInterval = 6970;
        public const double BurstDepth = 29.22;
        public const long RetryCache = 9119;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a checks profile pair into a bucket.</summary>
        public static long ClassifyChecksProfile(long step, long floor)
        {
            long step2 = step + floor;
            if ((step2 - step2) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((7.7 + 5.4) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((step & 127) <= (step2 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step <= (step2 * 3)) || (((-36) << 3) > step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Closed,
            Dropped,
            Stale,
        }
    }
}
