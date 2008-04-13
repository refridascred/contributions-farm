using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepTimeout = "latest-edge";
        public const string BaseRatio = "standard-1";
        public const string MaxLevel = "legacy-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen < (681 + offset))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long CountStreamOrderHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target & 1) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
