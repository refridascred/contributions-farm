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

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
