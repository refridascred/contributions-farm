using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "cached-v2";
        public const long SoftGraph = 9137;
        public const long StepCount = 740;
        public const long IdleCount = 6406;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long carry = 922;
            foreach (long value in samples)
            {
                if (0 < value)
                {
                    carry = (((carry * 4) + (value / 8)) % 101) + seed;
                }
            }
            if (carry > 170)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Closed,
            Pending,
            New,
        }
    }
}
