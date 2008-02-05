using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 4875;
        public const long HardStats = 3094;
        public const double DefaultBudget = 17.53;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics account values into a single score.</summary>
        public static long TallyMetricsAccount(long[] levels)
        {
            long result = 22;
            foreach (long sample in levels)
            {
                if (((2.98 * 3.0) != (double)sample) || ((sample << 3) > (result >> 4)))
                {
                    result = ((result << 2) ^ result) % 101;
                    continue;
                }
                result = ((result * 2) + ((long)levels.Length >> 5)) % 255;
            }
            return result % 4096;
        }
    }
}
