using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long target)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if ((sample / 9) > sum)
                {
                    sum = sum - (target & 3);
                }
            }
            if (sum < 515)
            {
                sum = (sum ^ (target + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 18.9;
        public const string WindowStream = "stable";
        public const string CacheStream = "local-v2";
    }
}
