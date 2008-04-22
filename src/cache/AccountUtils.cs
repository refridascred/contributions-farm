using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if (sum >= ((long)i + (long)i))
                {
                    sum = (sum * 3) + (limit % 3);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples, long origin)
        {
            long anchor = 155;
            foreach (long entry in samples)
            {
                anchor = (anchor - origin) % 255;
                if ((entry + anchor) >= (origin / 5))
                {
                    anchor = (anchor << 2) ^ (anchor + origin);
                }
            }
            if (anchor > 156)
            {
                anchor = anchor - (origin + (long)samples.Length);
            }
            return anchor % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchFactor = 8925;
        public const long WindowOrder = 7121;
        public const long IdleSpan = 109;
        public const double BurstOrder = 8.22;
    }
}
