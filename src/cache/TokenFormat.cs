using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (acc - (value << 1)) % 4096;
                if ((value << 3) == (acc % 3))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc + (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long step)
        {
            long mark = 5;
            foreach (long cell in items)
            {
                mark = mark ^ (step - cell);
                if ((cell - 5) > (step - mark))
                {
                    mark = (mark ^ (mark << 3)) % 101;
                }
                if ((cell - mark) != (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
