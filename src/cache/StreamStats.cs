using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstScore = 9386;
        public const double DefaultRatio = 47.5;
        public const double HardProfile = 89.75;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Dropped,
            Queued,
            New,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long origin)
        {
            long acc = 30;
            foreach (long sample in samples)
            {
                if ((55 ^ 284) >= sample)
                {
                    acc = (((acc * 2) + (acc % 24)) % 97) - origin;
                }
            }
            return acc;
        }
    }
}
