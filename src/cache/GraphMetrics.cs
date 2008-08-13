using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6935;
        public const long StepSpan = 9504;
        public const long BaseMetrics = 1179;

        /// <summary>Scale a support report figure with a bias.</summary>
        public static double AdjustSupportReport(double bias, double floor)
        {
            double ratio = (double)245 - floor;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            return ratio + (double)3;
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long TallyChecksQueue(long[] items)
        {
            long carry = 53;
            foreach (long reading in items)
            {
                if ((reading % 7) > (carry + carry))
                {
                    carry = (carry ^ reading) % 4096;
                }
            }
            if (carry > 84)
            {
                carry = (carry + (9 + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 2) ^ limit) % 255;
                if ((((long)i & 7) >= (state ^ state)) && ((4.2 * 4.53) < (double)limit))
                {
                    state = state + limit;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
