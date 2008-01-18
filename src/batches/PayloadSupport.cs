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

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values)
        {
            long state = 89;
            foreach (long entry in values)
            {
                if ((2.0 * 4.0) > (double)state)
                {
                    state = (state + (entry << 1)) % 65521;
                }
            }
            return state;
        }
    }
}
