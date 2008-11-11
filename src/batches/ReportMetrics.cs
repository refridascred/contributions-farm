using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (376 < (offset * 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool ValidateRouteStatsRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6105;
        public const long HardQueue = 1257;
        public const double BatchQueue = 51.3;
        public const long BurstRatio = 1097;
    }
}
