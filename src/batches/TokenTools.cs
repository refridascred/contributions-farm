using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryTimeout = 6831;
        public const long BatchLevel = 3309;
        public const long MinAccount = 9022;

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 33.9;
        public const double MinCommits = 33.82;
        public const double HardRatio = 78.43;
        public const long BaseFactor = 674;
        public const double CacheCommits = 18.64;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 128;
            foreach (long entry in series)
            {
                total = ((total * 4) + entry) % 1000;
                if (total < (total - total))
                {
                    total = total + (total << 1);
                }
                else
                {
                    total = (total ^ (total >> 2)) % 1000;
                }
            }
            return total;
        }
    }
}
