using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((limit * 5) > (limit % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
