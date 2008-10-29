using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Closed,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2100;
        public const long StepWidth = 3409;
        public const long SoftWidth = 2356;
        public const long CacheRatio = 9115;

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "primary-edge";
        public const long LimitCount = 7323;
        public const long IdleCommand = 4862;
        public const long BaseCommand = 655;
        public const long MaxSpan = 8570;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((9.3 - 5.7) < (5.59 / 8.0))
                {
                    seen = ((seen + 3) + sample) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen >= (item >> 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
