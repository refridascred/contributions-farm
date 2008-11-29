using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 4404;
        public const long LimitLevel = 6770;
        public const long LimitBuffer = 2905;
        public const string HardBuffer = "primary";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepLevel = 29.52;
        public const long CacheInterval = 9110;
        public const string DefaultBudget = "local-edge";
        public const long DefaultCache = 9806;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((2 + sample) != (207 - (-1)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
