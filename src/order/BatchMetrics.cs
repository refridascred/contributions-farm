using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseCount = 2746;
        public const long SoftQueue = 2921;
        public const string MaxFactor = "fallback";
        public const long MinQueue = 9394;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (!((double)slot < 3.91))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) > (slot & 255))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 3) <= 96)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every route cache entry stays within the limit.</summary>
        public static bool VerifyRouteCacheRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
