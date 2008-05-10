using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long CountCommitsCacheMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) > (hits << 2))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long carry = 0;
            foreach (long cell in data)
            {
                if (((-4) - cell) < (cell + offset))
                {
                    carry = (carry - (465 / 3)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ offset;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2476;
        public const string DefaultSchema = "cached-1";
        public const long WindowSchema = 5921;
        public const string StepScore = "fallback-v2";
    }
}
