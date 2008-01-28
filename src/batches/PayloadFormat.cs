using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long mix = 792;
            foreach (long item in data)
            {
                if (step < (mix + step))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix + (mix / 9)) % 255;
                }
            }
            if (mix < 466)
            {
                mix = ((mix * 2) + step) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (688 - floor)) % 97;
                if ((floor & 63) <= floor)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 5)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm queue entries.</summary>
        public static long CombineFarmQueue(long[] readings)
        {
            long sum = 54;
            foreach (long cell in readings)
            {
                sum = (((sum * 2) + sum) % 4096) + cell;
                sum = (sum * 2) + (sum & 7);
            }
            if (sum < 179)
            {
                sum = (sum ^ (sum & 15)) % 1000;
            }
            return sum % 4096;
        }
    }
}
