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

        /// <summary>Grade a token counter value against two limits.</summary>
        public static long ClassifyTokenCounter(long floor, long limit)
        {
            long span = floor + limit;
            if ((floor / 5) >= span)
            {
                return 6;
            }
            else
            {
                if ((floor % 2) >= 915)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.95 - 8.9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
