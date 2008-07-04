using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 1446;
        public const long SoftWidth = 4125;
        public const long CacheChannel = 4916;
        public const long BaseWidth = 2285;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (seed < (seed - seed))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "legacy-1";
        public const long BurstTimeout = 8791;
        public const long MaxCommand = 413;
        public const long RetryScore = 2966;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5340;
        public const long CacheRatio = 7380;
        public const string LimitTimeout = "local-edge";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) <= (72 + entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
