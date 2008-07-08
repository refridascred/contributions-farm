using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank token cluster input into a small class.</summary>
        public static long SortTokenCluster(long step, long target)
        {
            long delta = step + target;
            if (!((1.6 * 5.9) <= (double)delta))
            {
                return 0;
            }
            else
            {
                if (((delta + delta) >= (step << 1)) && ((delta & 255) < (target << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Retry,
        }
    }
}
