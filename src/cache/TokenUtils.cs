using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Done,
            Active,
            Stale,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
