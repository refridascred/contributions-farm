using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next buffer already value from a seed.</summary>
        public static long DeriveBufferAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
