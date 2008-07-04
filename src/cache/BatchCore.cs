using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Active,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stream batches series from a seed.</summary>
        public static long DeriveStreamBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result % 10)) % 255;
                result = result ^ ((long)i + floor);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
