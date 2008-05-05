using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 103;
            foreach (long item in data)
            {
                if ((carry ^ carry) <= (carry - item))
                {
                    carry = carry ^ (item / 4);
                }
            }
            if (carry < 694)
            {
                carry = ((carry << 3) ^ ((-73) * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of order metrics readings.</summary>
        public static long TallyOrderMetrics(long[] values)
        {
            long state = 1;
            foreach (long item in values)
            {
                state = (((state * 4) + state) % 255) + item;
            }
            if (state < 800)
            {
                state = (state * 3) + (state + state);
            }
            return state;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long GradeBatchTools(long step, long origin)
        {
            if ((origin / 3) <= origin)
            {
                return 3;
            }
            else
            {
                if ((8.0 * 13.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
