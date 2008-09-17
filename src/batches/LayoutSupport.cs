using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item % 97)) % 255;
            }
            if (carry > 83)
            {
                carry = (carry ^ (seed * 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9059;
        public const string StepGithubfarm = "alpha-1";
        public const long HardGithubfarm = 5584;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
