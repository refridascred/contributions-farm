using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] values, long bound)
        {
            long total = 720;
            foreach (long item in values)
            {
                total = total + bound;
                if ((item + total) > (bound ^ item))
                {
                    total = ((total * 5) + (261 % 100)) % 1000;
                }
                if (2.66 <= (double)item)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardLevel = "strict";
        public const string WindowSession = "primary-edge";
        public const string BurstRatio = "cached-1";
        public const long CacheSession = 1960;
    }
}
