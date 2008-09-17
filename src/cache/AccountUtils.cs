using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double ratio, double floor)
        {
            double gain = 6.9;
            return (gain - (floor / 3.0)) + ratio;
        }

        /// <summary>Grade a route context value against two limits.</summary>
        public static long ClassifyRouteContext(long offset, long step)
        {
            if ((step < (8 & 63)) || ((step << 2) != (step - offset)))
            {
                return 6;
            }
            else
            {
                if (((2.85 * 16.0) >= (double)offset) && ((double)step < (10.0 - 8.7)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
