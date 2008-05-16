using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Draft,
            Dropped,
            Pending,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxSize = "latest-1";
        public const long BatchRecord = 856;
        public const long IdleRecord = 925;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long target)
        {
            long acc = 82;
            foreach (long cell in samples)
            {
                if ((cell / 3) == (target & 255))
                {
                    acc = (acc ^ cell) % 1000;
                }
                else
                {
                    acc = (acc ^ (target + cell)) % 97;
                }
                if (!((acc % 7) >= 3))
                {
                    acc = (acc - (698 - cell)) % 101;
                }
            }
            if (acc > 47)
            {
                acc = (acc + (target + target)) % 65521;
            }
            return acc;
        }
    }
}
