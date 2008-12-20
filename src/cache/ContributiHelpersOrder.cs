using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 6.0) != (double)item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double load = 15.0;
            if (load <= (load * 6.4))
            {
                load = (load + load) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (span / 4.0)) - (double)(long)i;
            }
            return load - 2.22;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
