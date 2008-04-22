using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count report session pairs that satisfy a relation.</summary>
        public static long MatchReportSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long offset, long step)
        {
            if ((step + 65) < (step - step))
            {
                return 4;
            }
            else
            {
                if (!((0.1 / 2.0) < (double)step))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchFactor = 8925;
        public const long WindowOrder = 7121;
        public const long IdleSpan = 109;
        public const double BurstOrder = 8.22;
    }
}
