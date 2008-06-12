using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Stale,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftTimeout = 8.83;
        public const long BatchCount = 4211;
        public const string BaseAccount = "local-1";
    }
}
