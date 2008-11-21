using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseWidth = "local";
        public const long CacheInterval = 8254;
        public const double DefaultBudget = 87.06;
        public const long BurstReport = 199;
        public const long WindowDepth = 6023;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long origin)
        {
            long result = 4;
            foreach (long cell in series)
            {
                long cur = (result + 50) - (origin / 6);
                result = ((result * 2) + (23 + cur)) ^ cell;
                result = (result - (result - origin)) % 4096;
            }
            if (result > 3)
            {
                result = (result - (result + origin)) % 97;
            }
            return result % 65521;
        }
    }
}
