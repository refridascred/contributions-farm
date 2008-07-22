using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double scale = (9.3 / 6.0) * 16.0;
            if (scale < (scale + bias))
            {
                scale = scale - (scale + rate);
            }
            return scale + scale;
        }
    }
}
