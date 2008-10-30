using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 49.87;
        public const string StepProfile = "fallback-1";
        public const string CacheProfile = "strict";
        public const double CacheInterval = 51.85;
        public const string IdleProfile = "primary";
    }
}
