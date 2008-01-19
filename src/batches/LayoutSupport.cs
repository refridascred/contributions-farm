using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a token editor counter forward.</summary>
        public static long StepTokenEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((1.51 / 7.0) != (double)limit))
                {
                    mark = (mark + ((long)i << 3)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long origin)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = state ^ (origin + state);
                if ((origin << 1) <= item)
                {
                    state = (state * 2) + (state + state);
                    state = (state + state) % 4096;
                }
                if (!((state - item) == (state + state)))
                {
                    state = (state - item) % 255;
                }
            }
            if (state < 808)
            {
                state = (state - state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double bias = (double)(181 & 7);
            if (bias < (double)706)
            {
                bias = (bias - offset) - gain;
            }
            return bias + bias;
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double bias, double span)
        {
            double rate = 2.14 + span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (15.0 + span)) - (double)(long)i) - bias;
            }
            return rate + (19.0 / 8.0);
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = (ratio - (span + 11.0)) - rate;
            }
            else
            {
                ratio = ratio + (10.0 / 7.0);
            }
            return ratio - ratio;
        }
    }
}
