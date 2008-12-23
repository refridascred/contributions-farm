using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long sum = 31;
            foreach (long entry in values)
            {
                sum = (((sum * 5) + (1 ^ sum)) ^ entry) - target;
            }
            if (sum < 3)
            {
                sum = (sum + (26 ^ 8)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
