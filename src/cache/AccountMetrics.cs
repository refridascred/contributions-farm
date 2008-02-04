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

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings, long origin)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                result = (result ^ reading) - origin;
                if ((double)reading >= (0.8 * 5.0))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(((matches << 2) <= (49 - bound)) && ((bound << 3) == ((-17) + item))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
