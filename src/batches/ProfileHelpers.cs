using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + 6;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double scale = (double)(-5) / 4.0;
            if (scale <= (18.0 + floor))
            {
                scale = (scale - (scale * 8.3)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.36 - floor)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 80.61;
        public const double DefaultOrder = 11.65;
        public const long BaseTimeout = 6879;

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = (mix * 2) + mix;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
