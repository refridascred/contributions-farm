using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 12;
            foreach (long cell in items)
            {
                state = ((state ^ ((long)items.Length & 31)) % 4096) ^ cell;
            }
            if (state > 78)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = -9;
            foreach (long reading in series)
            {
                sum = (sum + (reading + reading)) % 1000;
            }
            if (sum > 217)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long bound)
        {
            if ((bound * 2) >= 152)
            {
                return 5;
            }
            else
            {
                if ((30 + floor) >= (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
