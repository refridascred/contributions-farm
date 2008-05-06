using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two checks already measurements.</summary>
        public static double AdjustChecksAlready(double rate, double span)
        {
            double load = 5.1;
            if (load >= 2.13)
            {
                load = (load - (load + load)) + span;
            }
            return load - (rate - 18.0);
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double drift = (weight * 6.5) * 1.9;
            return (drift - (double)31) + floor;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double drift = ratio;
            return drift + span;
        }
    }
}
