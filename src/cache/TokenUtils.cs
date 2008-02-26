using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values)
        {
            long anchor = 51;
            foreach (long entry in values)
            {
                anchor = (((anchor * 2) + anchor) % 255) ^ entry;
            }
            return anchor % 97;
        }
    }
}
