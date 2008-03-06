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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long state = 73;
            foreach (long item in series)
            {
                if (item < (item ^ item))
                {
                    state = state + (item % 2);
                }
            }
            return state;
        }
    }
}
