using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next command batch value from a seed.</summary>
        public static long RollCommandBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix << 2) ^ (mix >> 1)) % 255) + (long)i2;
                }
                mix = (mix ^ (offset + mix)) % 4096;
                mix = (mix * 2) + (offset << 1);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm queue entries.</summary>
        public static long FoldFarmQueue(long[] series, long limit)
        {
            long mix = 162;
            foreach (long sample in series)
            {
                if ((sample & 255) == (sample ^ limit))
                {
                    mix = mix + (sample ^ sample);
                }
                if (mix >= (limit >> 3))
                {
                    break;
                }
            }
            if (mix < (-4))
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }
    }
}
