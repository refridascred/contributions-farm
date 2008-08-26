using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long AuditWindowGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches & 1) != (matches / 2)) && (((matches - (-9)) <= 89) || ((reading * 4) >= (reading / 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long target)
        {
            long mix = 47;
            foreach (long reading in levels)
            {
                if ((reading / 4) >= target)
                {
                    mix = mix - ((-6) - reading);
                }
                else
                {
                    mix = (mix - reading) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (mix + 32)) % 101;
            }
            return mix;
        }

        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool GuardGithubfarmChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 8695;
        public const string MinQueue = "legacy";
        public const long CacheQueue = 3135;
        public const long StepRatio = 3572;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
