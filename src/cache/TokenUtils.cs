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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data, long seed)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = (total - (item % 12)) % 4096;
            }
            if (total > 43)
            {
                total = total + (seed >> 5);
            }
            return total;
        }
    }
}
