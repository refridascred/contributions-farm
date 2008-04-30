using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (double)(28 + (-90));
            if (scale >= (bias - bias))
            {
                scale = (scale - (1.85 * 4.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double drift = (double)(4 - 19);
            if (drift < (9.91 - drift))
            {
                drift = (drift + (drift / 8.0)) + span;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)248) - (double)(long)i;
            }
            return drift - (drift - scale);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
