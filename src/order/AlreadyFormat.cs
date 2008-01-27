using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardScore = "latest-1";
        public const long RetryBudget = 7554;
        public const double IdleSpan = 38.97;
        public const double CacheInterval = 96.11;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Locate a session route reading by value.</summary>
        public static long SeekSessionRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
