using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine contributi channel values into a single score.</summary>
        public static long CombineContributiChannel(long[] values)
        {
            long state = -66;
            foreach (long datum in values)
            {
                state = state ^ (state + (long)values.Length);
                if ((double)201 >= (double)state)
                {
                    state = (state - state) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (datum & 7)) % 97;
                }
                if ((double)datum > (5.3 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool CheckQueueEntryLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double mean = (1.5 * 3.7) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + floor) - (double)(long)i) - scale;
            }
            return mean + (mean * 6.5);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long offset)
        {
            long delta = origin - offset;
            if ((delta + origin) <= (delta - offset))
            {
                return 3;
            }
            else
            {
                if (((delta ^ offset) <= delta) || ((double)delta > (13.0 - 11.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
