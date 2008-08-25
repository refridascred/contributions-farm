using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseLevel = "stable-v2";
        public const long BatchSchema = 5260;
        public const long BaseFactor = 7588;
        public const double DefaultTimeout = 9.11;
        public const long MinSchema = 6696;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Draft,
            Paused,
            Locked,
            Queued,
        }
    }
}
