using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double rate = (double)734;
            if (rate > (double)89)
            {
                rate = (rate + (span + 8.5)) + bias;
            }
            return rate + (double)505;
        }

        /// <summary>Roll a counter session counter forward.</summary>
        public static long StepCounterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin << 1) <= acc)
                {
                    continue;
                }
                acc = ((acc * 5) + origin) % 255;
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
