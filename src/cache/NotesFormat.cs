using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long CompareContributiCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 56;
            foreach (long entry in data)
            {
                if ((1.3 / 2.0) > (double)mix)
                {
                    mix = (mix << 2) ^ (mix - (long)data.Length);
                }
                if (((4.0 / 3.0) != (double)(long)data.Length) || ((entry >> 2) != (85 + entry)))
                {
                    break;
                }
            }
            if (mix > 722)
            {
                mix = mix + (mix + 9);
            }
            return mix;
        }
    }
}
