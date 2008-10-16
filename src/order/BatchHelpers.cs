using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double scale = (rate / 5.0) - rate;
            if (scale > offset)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)29;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate - offset)) + (double)(long)i;
            }
            return scale - (4.21 - rate);
        }

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
