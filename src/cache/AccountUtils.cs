using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3404;
        public const double DefaultRoute = 76.02;
        public const double BaseRoute = 27.24;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long target)
        {
            long sum = 47;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sample + (long)samples.Length)) % 97) - target;
            }
            if (sum < 51)
            {
                sum = (sum + 805) % 255;
            }
            return sum % 4096;
        }
    }
}
