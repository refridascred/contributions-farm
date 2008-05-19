using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the checks metrics series from a seed.</summary>
        public static long RollChecksMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((2.0 * 2.76) < (double)step)
                {
                    mix = (mix << 2) ^ (step ^ step);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long target2)
        {
            if ((double)target == (double)target2)
            {
                return 5;
            }
            else
            {
                if ((target >> 5) >= target)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
