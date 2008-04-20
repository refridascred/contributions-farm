using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (origin2 > (origin2 + 373))
            {
                return 6;
            }
            else
            {
                if (((slot + origin2) == (origin + origin)) || ((origin2 ^ slot) >= (slot >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= 0.48)
            {
                mean = (mean - (bias / 2.0)) + ratio;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 518;
        public const double BaseRatio = 15.32;
        public const long IdleRoute = 6017;
    }
}
