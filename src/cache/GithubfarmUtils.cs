using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry % 16) >= (23 * 4))
                {
                    result = ((result * 4) + (entry % 16)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ entry) % 1000;
                }
            }
            if (result > 55)
            {
                result = result + (result ^ result);
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }
    }
}
