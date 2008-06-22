using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                mix = (((mix << 3) ^ 1) % 255) ^ item;
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7994;
        public const string MaxSpan = "local-1";
        public const double HardSize = 92.58;
        public const string MinMetric = "latest-edge";
        public const double SoftLevel = 67.21;

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxInterval = 23.24;
        public const long BurstInterval = 1781;
        public const double SoftTimeout = 81.59;
        public const long CacheToken = 3534;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
