using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = mix ^ (cell * 3);
            }
            return mix;
        }

        /// <summary>Adjust a metrics profile reading.</summary>
        public static double SmoothMetricsProfile(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= (double)7)
            {
                gain = gain + offset;
            }
            return gain - (gain / 2.0);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
