using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long DeriveContextLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 101;
            foreach (long item in items)
            {
                total = (((total << 3) ^ 9) % 1000) - item;
            }
            if (total > 414)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)target != (double)96))
                {
                    sum = (sum ^ (479 & 127)) % 101;
                }
                if (((8.08 + 6.68) <= (5.73 * 1.36)) && (sum > (5 - target)))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
