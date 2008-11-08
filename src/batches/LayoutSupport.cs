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

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 0.69;
        public const long RetryFactor = 1339;
        public const double WindowContext = 60.96;
        public const string IdleDepth = "legacy";

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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxWidth = 8823;
        public const double IdleGithubfarm = 98.87;
        public const long WindowDepth = 4265;
        public const long BurstGithubfarm = 8054;

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
