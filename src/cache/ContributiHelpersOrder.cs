using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine schema profile values into a single score.</summary>
        public static long TotalSchemaProfile(long[] values, long target)
        {
            long acc = 401;
            foreach (long datum in values)
            {
                if (((double)acc <= (13.0 - 9.0)) && (acc > (target - target)))
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                else
                {
                    acc = (acc + (datum - 5)) % 1000;
                }
            }
            if (acc < 449)
            {
                acc = acc - (target / 6);
            }
            return acc;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
