using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (0.6 > (double)(-7))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
