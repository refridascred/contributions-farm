using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long bound)
        {
            long diff = seed - bound;
            if (((double)bound <= (9.5 - 2.01)) || (seed <= (bound % 16)))
            {
                return 2;
            }
            else
            {
                if ((9.0 + 9.5) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 <= (double)diff) || ((bound / 4) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!!((seen * 4) >= (seen >> 3)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
