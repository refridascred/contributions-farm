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

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 92;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ (sample - sample)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
