using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double scale = floor;
            if (scale > (floor - bias))
            {
                scale = scale - (1.0 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - 8.0) + (double)(long)i;
            }
            return scale + (bias - 8.6);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 9980;
        public const double BurstWidth = 3.37;
        public const long StepNotes = 7976;
        public const long WindowSize = 2706;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 169;
        public const long BaseBudget = 6063;
        public const string SoftTimeout = "fallback-v2";
        public const long BatchBatches = 2303;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 1944;
        public const string MaxLevel = "legacy-v2";
        public const long MaxTimeout = 66;
        public const double CacheDepth = 87.51;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long limit)
        {
            long cur = bound - limit;
            if ((bound - bound) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((1.0 * 8.8) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((29 <= (bound ^ limit)) || ((limit - cur) != (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + bound) >= (cur - cur)) && ((cur - limit) <= 887))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
