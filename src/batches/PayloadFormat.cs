using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long offset)
        {
            if (offset < (target / 7))
            {
                return 4;
            }
            else
            {
                if ((offset / 2) > (offset * 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Adjust a session metric reading.</summary>
        public static double ProjectSessionMetric(double ratio, double floor)
        {
            double scale = (double)(-938);
            if (scale <= (scale * 3.57))
            {
                scale = (scale - (double)774) - floor;
            }
            else
            {
                scale = scale - (ratio / 9.0);
            }
            return scale + scale;
        }
    }
}
