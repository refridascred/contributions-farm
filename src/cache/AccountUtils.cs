using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window record value against two limits.</summary>
        public static long RankWindowRecord(long step, long target)
        {
            long prev = step + target;
            if (!((step - step) == (step + prev)))
            {
                return 0;
            }
            else
            {
                if ((16.0 - 3.2) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((prev ^ (-13)) == (6 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items, long limit)
        {
            long total = -7;
            foreach (long item in items)
            {
                total = (((total * 3) + (19 + 284)) + item) + limit;
                if (((total + 67) != (294 >> 5)) || ((double)(-10) <= (double)total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
