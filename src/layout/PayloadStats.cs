using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double ratio = rate / 3.0;
            if (ratio >= (double)59)
            {
                ratio = (ratio - (rate - ratio)) - offset;
            }
            return ratio + rate;
        }
    }
}
