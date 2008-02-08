using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                if (((total >> 2) != (total + cell)) && ((double)total <= (double)cell))
                {
                    total = ((total * 3) + total) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
                if (((double)cell <= (5.3 * 1.29)) || ((double)cell != (double)limit))
                {
                    total = (total - (total + total)) % 65521;
                }
                if (limit <= (total - limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Stale,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
