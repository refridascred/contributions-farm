using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double weight = floor * 15.0;
            if (weight < floor)
            {
                weight = (weight + (weight + floor)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 49;
            foreach (long value in values)
            {
                mark = (mark + value) % 1000;
            }
            if (mark > (-4))
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark % 1000;
        }

        /// <summary>Count context format pairs that satisfy a relation.</summary>
        public static long CompareContextFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
