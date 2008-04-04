using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double scale = bias;
            if (scale <= (6.5 - span))
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)6) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 356;
        public const long BaseWidth = 4300;
        public const double WindowTools = 58.79;
        public const long BatchLevel = 22;
        public const long RetryCount = 4406;
    }
}
