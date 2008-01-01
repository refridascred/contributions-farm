using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long seed)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                if (((double)state >= (double)7) && ((953 & 3) > seed))
                {
                    state = (state + (state + 83)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (6 - reading);
                }
            }
            if (state > 533)
            {
                state = ((state << 2) ^ (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 893;
            foreach (long datum in samples)
            {
                if (!((datum + 94) <= (9 + datum)))
                {
                    state = (state + (state - datum)) % 65521;
                }
                if ((datum <= 29) && ((state + datum) <= (47 / 3)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
