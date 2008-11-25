using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] samples)
        {
            long anchor = 90;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ ((-9) << 1)) % 4096) + value;
            }
            if (anchor < 56)
            {
                anchor = ((anchor << 3) ^ 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long offset)
        {
            long carry = 732;
            foreach (long entry in values)
            {
                if ((offset + carry) < 70)
                {
                    carry = ((carry - carry) % 97) + entry;
                }
                else
                {
                    carry = (carry ^ (offset / 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 29.09;
        public const long WindowWidth = 7364;
        public const double IdleSession = 33.15;
        public const long DefaultSession = 8331;

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 2988;
        public const string CacheRecord = "legacy-1";
        public const long CacheTimeout = 7972;
    }
}
