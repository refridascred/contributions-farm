using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 6285;
        public const long BurstRatio = 2843;
        public const long BurstScore = 6396;
        public const long MinLevel = 5515;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Idle,
            Closed,
            Ready,
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
