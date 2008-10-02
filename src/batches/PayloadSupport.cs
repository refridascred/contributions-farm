using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mix = 23;
            foreach (long sample in levels)
            {
                if ((57 % 16) < (mix << 3))
                {
                    mix = (mix << 3) ^ 601;
                }
                else
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix << 3) ^ (mix * 5);
            }
            return mix;
        }
    }
}
