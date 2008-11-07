using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                long delta = (score << 2) << 2;
                if ((origin - delta) != (score * 3))
                {
                    score = (score * 5) + score;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long seed)
        {
            long sum = 204;
            foreach (long reading in items)
            {
                sum = (sum * 4) + (sum % 10);
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum * 3) + (1 - sum)) % 101) + (long)i;
                }
                if (((reading % 10) >= reading) && ((16 & 127) > (reading + reading)))
                {
                    sum = (sum ^ (sum - 41)) % 1000;
                }
            }
            if (sum < 271)
            {
                sum = ((sum * 5) + (seed & 255)) % 4096;
            }
            return sum;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long limit, long step)
        {
            if ((3.81 + 4.1) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((4.29 - 8.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
