using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long seed)
        {
            long slot = bound - seed;
            if (((double)slot > 4.0) || (seed > (slot + bound)))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) <= (seed * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate queue token samples.</summary>
        public static long DigestQueueToken(long[] levels, long offset)
        {
            long sum = 907;
            foreach (long value in levels)
            {
                if ((5 * 3) <= (value >> 2))
                {
                    sum = (sum ^ (value << 2)) % 255;
                }
                if (!((double)offset >= (19.0 - 0.51)))
                {
                    sum = ((sum << 2) ^ (offset * 2)) % 4096;
                }
            }
            if (sum > 1)
            {
                sum = (sum + (offset + sum)) % 255;
            }
            return sum % 97;
        }
    }
}
