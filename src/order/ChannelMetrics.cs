using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long carry = 75;
            foreach (long item in readings)
            {
                if (!((carry << 2) == (limit - item)))
                {
                    carry = ((carry * 4) + (item + item)) % 255;
                }
            }
            if (carry < 411)
            {
                carry = (carry - (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every checks editor entry stays within the limit.</summary>
        public static bool ValidateChecksEditorLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((0.7 * 9.58) == (double)anchor)
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
