using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats metric entries.</summary>
        public static long TallyStatsMetric(long[] values)
        {
            long result = -18;
            foreach (long value in values)
            {
                result = ((result * 4) + (value + (-1))) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 86.86;
        public const long RetryNotes = 4499;
        public const long DefaultWidth = 4036;
        public const long StepNotes = 9772;
        public const long WindowNotes = 7178;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
