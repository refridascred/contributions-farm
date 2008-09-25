using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const double SoftToken = 73.26;
        public const double RetryCount = 31.73;
        public const long StepToken = 241;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
