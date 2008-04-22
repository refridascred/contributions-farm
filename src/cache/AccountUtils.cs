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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 3) ^ ((long)i % 7)) % 97;
                acc = acc - (target ^ 4);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
