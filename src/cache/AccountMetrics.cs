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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long result = -89;
            foreach (long item in items)
            {
                result = (result * 5) + (step / 3);
                result = (result * 5) + (result + step);
                result = (result + result) % 65521;
                if ((item ^ step) < (item + step))
                {
                    break;
                }
            }
            return result;
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
