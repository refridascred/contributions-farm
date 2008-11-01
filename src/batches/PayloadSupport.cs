using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool GuardBatchOrderRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window queue samples.</summary>
        public static long TotalWindowQueue(long[] samples, long offset)
        {
            long mix = 86;
            foreach (long item in samples)
            {
                if ((9 % 97) <= (offset + mix))
                {
                    mix = (mix * 5) + (offset ^ item);
                }
                else
                {
                    mix = mix ^ (item - offset);
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Match up stream queue samples.</summary>
        public static long PairStreamQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
