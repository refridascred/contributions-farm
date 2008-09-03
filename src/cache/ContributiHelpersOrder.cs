using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 5) > 3)
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((step ^ step) != (gap % 10))
            {
                return 1;
            }
            else
            {
                if (((-293) ^ step) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-7)) >= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ 83) != (9 >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
