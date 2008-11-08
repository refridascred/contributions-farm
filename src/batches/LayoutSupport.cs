using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 2958;
        public const long BurstFactor = 772;
        public const double MaxCount = 30.9;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Digest a series of channel filter entries.</summary>
        public static long TotalChannelFilter(long[] data, long target)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (!((2.2 + 9.0) == (double)datum))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry > 1)
            {
                carry = (carry - (target - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
