using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double span)
        {
            double scale2 = (double)(278 % 10);
            if (scale2 < (double)66)
            {
                scale2 = (scale2 + (span + 7.08)) + scale;
            }
            else
            {
                scale2 = scale2 + (scale2 * 2.89);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (span * 1.0)) + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (state - state)) % 101;
                state = (state ^ floor) % 255;
                if ((state + state) > 718)
                {
                    state = (state - (21 & 127)) % 65521;
                    break;
                }
                else
                {
                    state = ((state * 2) + (floor % 3)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long offset)
        {
            if ((76 + limit) != (519 + 557))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) <= (offset * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Failed,
            Draft,
        }
    }
}
