using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7644;
        public const double RetryGithubfarm = 22.09;
        public const long BaseLevel = 5485;
        public const string DefaultCount = "legacy-1";
        public const long RetryInterval = 5494;

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long FoldMetricsRoute(long[] values, long seed)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if (((double)cell < (7.14 + 3.1)) || ((2.94 - 6.62) >= (double)cell))
                {
                    total = (((total << 2) ^ (9 >> 4)) % 101) - seed;
                }
                else
                {
                    total = ((total << 3) ^ 2) % 1000;
                }
            }
            if (total < 40)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] series, long limit)
        {
            long state = 4;
            foreach (long reading in series)
            {
                if ((double)reading != (3.0 + 3.31))
                {
                    state = ((state * 5) + (limit - reading)) % 4096;
                }
            }
            return state;
        }
    }
}
