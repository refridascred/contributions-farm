using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Stale,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long AuditSessionBatchesMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((origin + origin) <= ((-6) + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((0 - 1) < (target << 3)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
