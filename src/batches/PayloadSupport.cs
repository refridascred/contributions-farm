using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double load = (double)(50 ^ 1);
            if (load <= (double)2)
            {
                load = load - (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Scale a route support figure with a bias.</summary>
        public static double ScaleRouteSupport(double scale, double bias)
        {
            double rate = scale;
            if (rate >= (rate / 9.0))
            {
                rate = rate - (bias - scale);
            }
            else
            {
                rate = rate + (bias + rate);
            }
            return rate - (bias + rate);
        }
    }
}
