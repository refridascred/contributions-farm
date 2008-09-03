using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = 114;
            foreach (long sample in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - 51) % 4096) + (long)i;
                    total = (total ^ (total >> 1)) % 97;
                }
                total = ((total * 5) + (sample ^ sample)) % 4096;
            }
            if (total > 64)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
