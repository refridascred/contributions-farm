using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = weight;
            if (bias >= span)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span + bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ floor;
                state = (state + (state + floor)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
