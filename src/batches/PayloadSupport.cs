using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if (((offset & 7) <= (offset >> 2)) || (offset > (offset % 97)))
            {
                return 5;
            }
            else
            {
                if (((offset % 3) <= seed) && ((double)offset > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (!(9 >= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if (5.0 > (double)cell)
                {
                    state = ((state + 39) % 4096) - bound;
                }
            }
            return state;
        }
    }
}
