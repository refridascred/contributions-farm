using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool ValidateBatchQueueLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4603;
        public const long CacheRatio = 882;
        public const long BatchSize = 7459;
    }
}
