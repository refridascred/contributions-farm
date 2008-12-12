using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long floor, long target)
        {
            if ((target + target) >= (floor & 7))
            {
                return 4;
            }
            else
            {
                if (1.0 >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data)
        {
            long total = 79;
            foreach (long reading in data)
            {
                total = (total - (4 ^ reading)) % 4096;
            }
            return total;
        }

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry + 3) < 41))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
