using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate batch farm readings against a bound.</summary>
        public static bool ValidateBatchFarmBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next route counter value.</summary>
        public static double BlendRouteCounter(double scale, double offset)
        {
            double scale2 = (offset - scale) / 7.0;
            if (scale2 < 8.7)
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (double)(-48);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels)
        {
            long state = 133;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= (32 * 3))
                {
                    state = (state - (state / 8)) % 65521;
                }
                else
                {
                    state = (state * 5) + cell;
                }
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long result = 406;
            foreach (long value in levels)
            {
                if ((81 * 5) > result)
                {
                    result = ((result << 3) ^ value) % 255;
                }
            }
            if (result < 36)
            {
                result = result - result;
            }
            return result % 4096;
        }
    }
}
