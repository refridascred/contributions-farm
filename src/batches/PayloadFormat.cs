using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support session entries.</summary>
        public static long CombineSupportSession(long[] samples)
        {
            long state = 334;
            foreach (long value in samples)
            {
                if ((double)value >= (1.1 + 3.9))
                {
                    break;
                }
                if ((value / 4) <= (0 - value))
                {
                    state = (state ^ state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
