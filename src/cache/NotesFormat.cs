using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every metric filter entry stays within the limit.</summary>
        public static bool GuardMetricFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (8.0 - bias))
            {
                bias3 = (bias3 - bias3) - bias2;
            }
            return bias3 + (double)879;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long mark = 86;
            foreach (long sample in values)
            {
                if (((double)mark == (4.0 / 3.0)) || ((sample + mark) != (mark & 63)))
                {
                    mark = (mark << 2) ^ ((-99) + 9);
                }
                mark = (mark + mark) % 255;
            }
            if (mark < 42)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
