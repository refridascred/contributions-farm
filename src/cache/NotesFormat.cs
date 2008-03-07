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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
