using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Blend two command layout measurements.</summary>
        public static double AdjustCommandLayout(double scale, double offset)
        {
            double drift = offset;
            if (drift <= (offset * 6.2))
            {
                drift = (drift - drift) - scale;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 6.0) + (double)(long)i;
            }
            return drift + (drift * 15.0);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long seed)
        {
            if ((double)limit >= (11.0 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
