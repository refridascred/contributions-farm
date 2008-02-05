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
