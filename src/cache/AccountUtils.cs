using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double gain = (double)20 * 4.55;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (gain - offset)) + (double)(long)i) + ratio;
            }
            return gain - (gain + gain);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long offset)
        {
            long offset2 = target + offset;
            if ((double)target < (double)136)
            {
                return 8;
            }
            else
            {
                if (1.9 <= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
