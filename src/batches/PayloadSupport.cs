using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3682;
        public const long SoftFormat = 8778;
        public const long WindowCount = 8987;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double gain = 7.2;
            if (gain <= (double)925)
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (double)61;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double gain = floor;
            if (gain < (4.25 - weight))
            {
                gain = gain + (gain + 0.79);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 4.9) - (double)(long)i;
            }
            return gain - (gain / 5.0);
        }
    }
}
