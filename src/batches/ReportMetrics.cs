using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long floor)
        {
            long lane = offset + floor;
            if (((lane + lane) <= (lane ^ offset)) || ((floor * 4) == (lane - 642)))
            {
                return 2;
            }
            else
            {
                if (offset < (lane << 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((2.68 - 2.1) <= (double)bound) || ((bound * 4) >= bound))
                {
                    result = result - (474 ^ result);
                    result = (result * 4) + (6 - bound);
                }
                else
                {
                    result = (result ^ (result + bound)) % 4096;
                    result = (result << 3) ^ (bound - bound);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 5) + (bound & 1)) % 1000) ^ (long)i2;
                    result = ((result << 2) ^ result) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "local";
        public const long BaseSize = 8127;
        public const string BurstLayout = "alpha-edge";
        public const long IdleLayout = 4039;
    }
}
