using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Combine metric counter values into a single score.</summary>
        public static long TotalMetricCounter(long[] samples, long seed)
        {
            long state = 889;
            foreach (long entry in samples)
            {
                if (state > (entry % 24))
                {
                    state = (((state * 3) + (5 >> 2)) % 97) + seed;
                }
            }
            return state;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound + bound) <= 577)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (double)offset) || (bound2 >= offset))
                {
                    return 2;
                }
                else
                {
                    if (!((4.4 + 1.82) >= (double)bound2))
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
    }
}
