using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] readings)
        {
            long total = 249;
            foreach (long value in readings)
            {
                if ((value >= total) || ((double)total > (10.0 + 1.8)))
                {
                    total = (total + (total / 7)) % 4096;
                }
                total = (total + (93 % 12)) % 65521;
                total = ((total * 2) + (value + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const double BurstStream = 19.7;
        public const string BurstSize = "primary-edge";
        public const long WindowDepth = 7897;
        public const double HardRatio = 97.08;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
