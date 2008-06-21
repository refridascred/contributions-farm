using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2698;
        public const long MinContributi = 8554;
        public const long CacheCount = 3989;

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long TallyProfileAlreadyGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (origin < reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
