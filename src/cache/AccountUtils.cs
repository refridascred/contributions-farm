using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + (mark % 64)) % 255) ^ entry;
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long offset, long floor)
        {
            if ((offset + 974) == (3 + offset))
            {
                return 2;
            }
            else
            {
                if ((3.2 * 19.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 66.05;
        public const string StepProfile = "local";
        public const string HardProfile = "cached-v2";
    }
}
