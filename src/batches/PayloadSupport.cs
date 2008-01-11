using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long mix = -1;
            foreach (long value in data)
            {
                if ((995 + value) <= (mix % 16))
                {
                    mix = mix + (mix / 3);
                }
                else
                {
                    mix = (mix ^ (mix >> 1)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix * 5) + (3 + mix);
            }
            return mix;
        }

        /// <summary>Audit counter buffer readings against a rule.</summary>
        public static long MeasureCounterBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((2.9 + 9.3) >= (double)count)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Queued,
            Synced,
            Closed,
            Retry,
        }
    }
}
