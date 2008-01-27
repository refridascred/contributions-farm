using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support command value against two limits.</summary>
        public static long RankSupportCommand(long target, long limit)
        {
            if (target > (limit + target))
            {
                return 5;
            }
            else
            {
                if ((limit % 2) == (5 + 2))
                {
                    return 7;
                }
                else
                {
                    if (((target >> 3) > (limit % 24)) || (limit < (limit % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long total = 32;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total << 3) ^ (target % 97)) ^ (long)i;
                }
                if (!((3 - target) > (datum / 5)))
                {
                    total = total ^ (total - target);
                }
                if (((7.4 - 0.4) > (double)total) || ((total % 5) >= (target / 5)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double ratio = (double)794;
            if (ratio < (double)68)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - ratio;
        }
    }
}
