using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchTimeout = 88.62;
        public const long CacheContext = 1019;
        public const string BaseSpan = "open-1";
        public const double SoftContext = 74.55;
        public const double StepContext = 33.08;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftLevel = 44.04;
        public const long MaxSize = 8141;
        public const long RetryBudget = 1764;
        public const string BurstDepth = "standard-v2";
        public const string IdleStream = "strict-v2";

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
