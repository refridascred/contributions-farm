using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 510;
            foreach (long sample in samples)
            {
                total = (total - sample) % 65521;
                total = ((total << 2) ^ (585 / 2)) % 101;
                total = total + (total >> 5);
            }
            if (total > 9)
            {
                total = (total - (total & 31)) % 97;
            }
            return total;
        }
    }
}
