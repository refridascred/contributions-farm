using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (13 > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values, long seed)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if (30 > (acc * 3))
                {
                    acc = ((((acc << 2) ^ (acc % 2)) % 65521) - sample) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two layout filter measurements.</summary>
        public static double SmoothLayoutFilter(double gain, double span)
        {
            double drift = (double)313 * 5.23;
            if (drift < span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (9.7 / 7.0);
            }
            return drift + gain;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double scale = bias;
            return (scale - (4.0 / 9.0)) + bias2;
        }
    }
}
