using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double scale = (double)4;
            if (scale >= (offset - bias))
            {
                scale = scale + (bias + scale);
            }
            return scale + (scale - 7.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 7531;
        public const string StepStream = "strict-1";
        public const double HardStream = 15.96;
        public const double CacheTimeout = 64.71;
        public const long MinTimeout = 4054;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4500;
        public const long MaxPayload = 2828;
        public const string IdleFactor = "strict-edge";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
