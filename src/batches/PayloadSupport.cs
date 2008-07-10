using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 4494;
        public const double MinReport = 84.39;
        public const long CacheTimeout = 698;
        public const string MaxTimeout = "cached-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 10.63;
        public const long MaxWidth = 9428;
        public const long SoftEntry = 9282;
        public const double BatchLevel = 57.97;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double ratio = span / 5.0;
            if (ratio >= (4.12 + 12.0))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio + (gain - span);
        }
    }
}
