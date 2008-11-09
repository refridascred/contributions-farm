using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 5287;
        public const long LimitStream = 8192;
        public const long BatchStream = 3362;
        public const long WindowStream = 4524;
        public const double IdleFactor = 32.5;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] data, long target)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if ((2 ^ mark) <= target)
                {
                    mark = ((mark - mark) % 1000) + cell;
                }
            }
            if (mark > 198)
            {
                mark = (mark ^ (mark >> 1)) % 101;
            }
            return mark;
        }
    }
}
