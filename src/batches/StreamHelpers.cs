using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long target)
        {
            if ((1.0 * 3.1) != (double)target)
            {
                return 4;
            }
            else
            {
                if ((floor * 2) >= ((-61) & 1))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double bias = 2.0 - (double)31;
            if (bias > rate)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (6.96 - floor);
            }
            return bias + floor;
        }

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long StepCommandCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 3) ^ limit) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 6137;
        public const long MaxCounter = 4303;
        public const double WindowCounter = 18.91;
    }
}
