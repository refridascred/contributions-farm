using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 96.81;
        public const double MinMetrics = 90.11;
        public const double CacheSpan = 74.39;
        public const double BaseMetrics = 7.51;
        public const long BurstFactor = 1600;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (acc - (reading << 3)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of metric schema readings.</summary>
        public static long WeighMetricSchema(long[] values)
        {
            long total = 837;
            foreach (long entry in values)
            {
                total = total - (total + entry);
                if ((total / 6) == (entry + entry))
                {
                    total = (total + (entry + total)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + entry)) % 97;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + (total << 1)) % 97;
            }
            return total % 4096;
        }
    }
}
