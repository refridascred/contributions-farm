using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long target)
        {
            long mark = 421;
            foreach (long reading in readings)
            {
                mark = ((mark + (target - 488)) % 65521) ^ reading;
            }
            if (mark < 300)
            {
                mark = mark + (target + mark);
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double bias = span;
            return bias - weight;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
