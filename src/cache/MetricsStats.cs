using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total + (datum ^ datum)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long result = 921;
            foreach (long reading in readings)
            {
                result = (result - (floor + (long)readings.Length)) % 255;
                if ((long)readings.Length > (result - reading))
                {
                    result = (result << 2) ^ floor;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((1.0 * 17.0) != (double)seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
