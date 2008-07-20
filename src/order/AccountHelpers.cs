using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
