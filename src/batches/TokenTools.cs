using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > hits)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double mean = 4.0;
            if (mean > (double)59)
            {
                mean = mean + bias2;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (bias2 * 4.4);
        }
    }
}
