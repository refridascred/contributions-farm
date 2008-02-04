using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (offset << 3)) % 65521) ^ (long)i2;
                }
                if (!((double)mix <= 15.0))
                {
                    mix = (mix << 3) ^ (long)i;
                }
                else
                {
                    mix = (mix + (offset ^ offset)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a context format sample.</summary>
        public static long SeekContextFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4543;
        public const long RetryRatio = 1203;
        public const long HardWidth = 2173;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 69.81;
        public const long IdleBudget = 4197;
        public const long LimitSize = 3542;
        public const long BatchTimeout = 3194;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 1509;
        public const long CacheInterval = 2016;
        public const string BaseFactor = "latest-v2";
    }
}
