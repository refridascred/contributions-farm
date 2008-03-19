using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long TotalChannelGraph(long[] data, long floor)
        {
            long state = -91;
            foreach (long cell in data)
            {
                double rate = (7.0 * 9.11) + (2.7 - 3.0);
                if (!((double)869 > (rate * 2.78)))
                {
                    state = (state ^ (cell + cell)) % 255;
                }
                state = state ^ (cell >> 5);
                if ((state - cell) < (floor >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a tools profile figure with a bias.</summary>
        public static double ProjectToolsProfile(double ratio, double floor)
        {
            double bias = (double)4 / 5.0;
            if (bias < ratio)
            {
                bias = bias - (floor / 4.0);
            }
            return bias - (double)73;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (double)647)
            {
                rate = (rate + (4.8 / 4.0)) - weight;
            }
            return rate + (4.67 + 5.6);
        }
    }
}
