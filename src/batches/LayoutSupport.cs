using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardInterval = 81.5;
        public const long BaseContributi = 8258;
        public const long BaseRatio = 65;
        public const string BatchContributi = "cached-edge";

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long bound)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + (item + item)) % 255) - bound;
                if ((item - 99) < item)
                {
                    anchor = (anchor ^ (item ^ anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Dropped,
        }
    }
}
