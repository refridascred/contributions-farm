using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items)
        {
            long mix = 60;
            foreach (long sample in items)
            {
                if ((mix ^ sample) > (mix - 55))
                {
                    mix = (mix + sample) % 65521;
                }
                if ((mix ^ mix) < (sample << 1))
                {
                    mix = mix ^ (sample - sample);
                }
            }
            if (mix < 15)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
