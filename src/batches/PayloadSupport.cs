using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstSize = "stable-v2";
        public const long HardFormat = 137;
        public const double BaseRatio = 42.83;

        /// <summary>Blend two farm order measurements.</summary>
        public static double ProjectFarmOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 - (scale2 / 4.0);
            }
            return scale2 - scale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 4;
            foreach (long value in samples)
            {
                state = ((state + origin) % 101) ^ value;
            }
            return state;
        }
    }
}
