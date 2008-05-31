using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Paused,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
