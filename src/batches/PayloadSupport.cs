using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!!((floor + 26) != (4 * 2)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            New,
            Pending,
        }
    }
}
