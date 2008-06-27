using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (8.0 < (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Blend two channel cache measurements.</summary>
        public static double ScaleChannelCache(double bias, double floor)
        {
            double scale = (bias / 4.0) / 4.0;
            return scale + (floor - bias);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long mark = 528;
            foreach (long entry in values)
            {
                mark = (((mark ^ mark) % 97) ^ entry) - offset;
            }
            if (mark > 26)
            {
                mark = mark ^ (mark / 4);
            }
            return mark;
        }
    }
}
