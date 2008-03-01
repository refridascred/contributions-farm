using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long offset)
        {
            long state = 596;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state + cell) % 97) - (long)i) - offset;
                }
                state = state - cell;
            }
            if (state < 98)
            {
                state = ((state * 2) + state) % 65521;
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)bound < (3.05 * 17.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
