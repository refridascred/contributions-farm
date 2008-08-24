using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((total - 9) < (total + 585))
                {
                    total = total ^ (long)levels.Length;
                }
                if ((entry ^ entry) != (entry + 918))
                {
                    break;
                }
            }
            if (total > 860)
            {
                total = (total * 2) + total;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of route batch readings.</summary>
        public static long TotalRouteBatch(long[] readings)
        {
            long carry = 749;
            foreach (long item in readings)
            {
                carry = carry - (item ^ item);
                if (item >= carry)
                {
                    carry = carry + (item + item);
                }
            }
            return carry;
        }

        /// <summary>Iterate the context token series from a seed.</summary>
        public static long IterateContextToken(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + (long)i) > (target + 562))
                {
                    state = ((state << 3) ^ (state - state)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
