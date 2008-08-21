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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Pending,
            Dropped,
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
