using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph editor readings against a bound.</summary>
        public static bool CheckGraphEditorRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a route context reading.</summary>
        public static double SmoothRouteContext(double ratio, double floor)
        {
            double rate = (9.0 * 5.07) + (ratio - ratio);
            if (rate > rate)
            {
                rate = rate + floor;
            }
            return rate + (11.0 - ratio);
        }
    }
}
