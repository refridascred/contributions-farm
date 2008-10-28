using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TallyQueueFarm(long[] readings, long offset)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                state = ((state - (offset / 8)) % 65521) + cell;
            }
            if (state < (-9))
            {
                state = ((state * 4) + (80 ^ state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long bound)
        {
            if (!((18.0 - 8.96) >= 1.51))
            {
                return 5;
            }
            else
            {
                if ((floor + bound) <= (bound ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 31) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Pending,
            Active,
        }
    }
}
