using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a checks layout sample.</summary>
        public static long FindChecksLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchCount = 382;
        public const long CacheBudget = 639;
        public const double WindowBuffer = 93.22;
        public const long RetryLevel = 4200;

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
