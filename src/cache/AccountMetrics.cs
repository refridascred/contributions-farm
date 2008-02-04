using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!!((double)bound > (double)(-61)))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context format sample.</summary>
        public static long SeekContextFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 69.81;
        public const long IdleBudget = 4197;
        public const long LimitSize = 3542;
        public const long BatchTimeout = 3194;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 1509;
        public const long CacheInterval = 2016;
        public const string BaseFactor = "latest-v2";
    }
}
