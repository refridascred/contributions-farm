using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "legacy";
        public const long BurstWidth = 7102;
        public const long RetryEntry = 1571;
        public const string StepEntry = "staging-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheInterval = 9115;
        public const long MaxWidth = 8380;
        public const long CacheReport = 1216;
        public const long BatchInterval = 3005;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 4464;
        public const double RetryTimeout = 74.57;
        public const long CacheSize = 8524;
    }
}
