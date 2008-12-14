using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 220;
        public const string HardEntry = "strict";
        public const string BaseEntry = "stable-edge";
        public const long RetryScore = 8334;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
