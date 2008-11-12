using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account githubfarm readings.</summary>
        public static long DigestAccountGithubfarm(long[] series, long origin)
        {
            long state = 526;
            foreach (long value in series)
            {
                state = ((((state << 3) ^ state) % 65521) - value) + origin;
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleTimeout = "standard-v2";
        public const long BaseCommand = 3675;
        public const double IdleCommand = 87.48;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
