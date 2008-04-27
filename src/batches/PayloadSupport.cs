using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (floor < (seen % 64))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Locked,
            Synced,
            Paused,
        }
    }
}
