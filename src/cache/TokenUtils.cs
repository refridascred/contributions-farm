using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if (!((mix - mix) >= mix))
                {
                    mix = ((mix * 4) + value) % 97;
                }
                mix = (mix - (value - mix)) % 97;
            }
            if (mix < 68)
            {
                mix = mix ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = sum - (datum % 60);
                if ((seed << 2) <= 76)
                {
                    sum = sum - seed;
                }
                else
                {
                    sum = (sum - (seed % 16)) % 97;
                }
            }
            if (sum > 480)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
