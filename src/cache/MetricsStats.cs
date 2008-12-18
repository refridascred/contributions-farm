using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 4992;
        public const long MaxDepth = 8530;
        public const long CacheCount = 9043;
        public const long BurstWidth = 8752;
        public const long HardFactor = 3949;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double bias = offset;
            if (bias > (offset * 8.79))
            {
                bias = (bias + offset) - ratio;
            }
            else
            {
                bias = bias + (double)(-926);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((datum << 1) == (9 - matches)) && ((matches << 1) <= (step ^ datum))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
