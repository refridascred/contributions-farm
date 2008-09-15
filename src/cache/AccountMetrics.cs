using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitInterval = 94.02;
        public const double MaxSpan = 16.52;
        public const string RetryFactor = "staging-1";

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (!((target * 2) >= 84))
            {
                return 3;
            }
            else
            {
                if (!((target - target) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((target * 2) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6374;
        public const string BurstCounter = "fallback-v2";
        public const long BurstScore = 1947;

        /// <summary>Look up the position of a commits order sample.</summary>
        public static long FindCommitsOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
