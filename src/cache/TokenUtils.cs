using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally >= 4.0)
                {
                    tally = ((tally + 2) + value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
