using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + ((-46) ^ mark)) % 255;
                mark = mark ^ (mark + mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long step2)
        {
            long gap = step - step2;
            if ((step + step2) >= 3)
            {
                return 7;
            }
            else
            {
                if ((step + gap) > gap)
                {
                    return 6;
                }
                else
                {
                    if ((double)step == (5.08 * 6.8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 89;
            foreach (long cell in values)
            {
                if ((0.93 * 7.0) > (double)carry)
                {
                    carry = (carry ^ (cell - 885)) % 97;
                }
            }
            return carry;
        }
    }
}
