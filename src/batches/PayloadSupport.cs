using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if ((8.8 + 4.35) < (double)total)
                {
                    total = (total ^ (total & 1)) % 255;
                }
                else
                {
                    total = (total * 5) + (target << 2);
                    total = (total ^ (total ^ target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long state = 9;
            foreach (long entry in items)
            {
                state = state ^ (entry + bound);
            }
            if (state < (-1))
            {
                state = (state - state) % 65521;
            }
            return state % 1000;
        }
    }
}
