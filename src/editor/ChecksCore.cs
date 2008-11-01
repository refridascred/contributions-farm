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

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long MeasureTokenProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (0.3 > (double)count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 49.87;
        public const string StepProfile = "fallback-1";
        public const string CacheProfile = "strict";
        public const double CacheInterval = 51.85;
        public const string IdleProfile = "primary";
    }
}
