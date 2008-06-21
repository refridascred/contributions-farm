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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ (long)i) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
