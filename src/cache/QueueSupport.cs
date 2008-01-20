using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 75.54;
        public const string RetryInterval = "standard";
        public const long RetrySchema = 1897;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
