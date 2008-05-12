using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long ClassifyReportGraph(long step, long limit)
        {
            if (((double)step > (7.6 + 3.4)) || (9 > limit))
            {
                return 4;
            }
            else
            {
                if (!((limit & 15) >= (limit >> 2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (5.5 * 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
