using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long BatchLayout = 8598;
        public const long BaseLevel = 9613;
        public const long StepLayout = 8254;
        public const long MinLayout = 2155;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
