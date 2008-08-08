using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long mix = 45;
            foreach (long entry in readings)
            {
                mix = mix ^ (mix + mix);
                if (!(((double)step == (double)mix) && ((double)entry != (double)6)))
                {
                    mix = (mix * 3) + 15;
                }
                if ((8.8 / 9.0) <= (double)(long)readings.Length)
                {
                    mix = ((mix << 3) ^ (entry * 5)) % 1000;
                }
            }
            if (mix < 10)
            {
                mix = (mix << 3) ^ (step - step);
            }
            return mix;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Active,
            Dropped,
            Failed,
        }
    }
}
