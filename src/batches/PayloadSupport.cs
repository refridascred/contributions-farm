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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long mix = 9;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (mix << 2)) ^ (long)i;
                    mix = mix ^ (entry & 63);
                }
                mix = (mix - 21) % 255;
                if (!((2.55 - 8.0) < (double)entry))
                {
                    break;
                }
            }
            return mix % 4096;
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
