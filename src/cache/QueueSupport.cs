using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two support contributi measurements.</summary>
        public static double SmoothSupportContributi(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (bias2 / 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias - bias2)) + (double)(long)i;
            }
            return ratio + (bias - 3.79);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + (step ^ anchor)) % 1000) + item;
            }
            return anchor;
        }

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long CountOrderChannelOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((matches << 3) > 156) && ((matches + datum) < (datum / 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
