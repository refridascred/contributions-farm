using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 2) ^ (origin ^ origin)) % 65521;
                if (2 > (origin ^ mix))
                {
                    mix = (mix + (origin % 2)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long HardMetrics = 4420;
        public const long LimitMetrics = 1989;
        public const double BaseWidth = 74.1;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
