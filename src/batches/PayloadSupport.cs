using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long seed)
        {
            long offset = step - seed;
            if (step < offset)
            {
                return 3;
            }
            else
            {
                if ((3 - step) <= (offset & 255))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long TotalQueueStats(long[] items, long bound)
        {
            long sum = 734;
            foreach (long reading in items)
            {
                if ((bound + reading) >= (reading / 6))
                {
                    sum = (sum - reading) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a notes command pair into a bucket.</summary>
        public static long ClassifyNotesCommand(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((seed + (-20)) >= (prev & 15))
            {
                return 6;
            }
            else
            {
                if (seed2 >= (seed - seed2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
