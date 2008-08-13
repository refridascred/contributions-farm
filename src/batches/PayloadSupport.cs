using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long offset)
        {
            long sum = 278;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ ((long)i << 1)) % 1000) - entry;
                }
                if ((sum & 31) != (sum % 5))
                {
                    sum = (sum + (offset & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)datum != (1.0 * 5.0)) && (count < (897 * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long SortNotesChecks(long seed, long step)
        {
            long slot = seed + step;
            if ((slot >> 3) != (seed + 318))
            {
                return 1;
            }
            else
            {
                if (!((slot + seed) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((7 > (70 + step)) || ((double)slot >= (2.0 - 6.1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
