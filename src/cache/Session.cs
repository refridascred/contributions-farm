using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "primary";
        public const double BatchPayload = 7.88;
        public const double HardPayload = 1.64;
        public const double WindowPayload = 21.77;
        public const double BurstSpan = 5.72;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Project the next schema context value.</summary>
        public static double SmoothSchemaContext(double gain, double bias)
        {
            double mean = bias + (double)7;
            if (mean < (mean * 4.7))
            {
                mean = (mean + bias) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 19.0) + (double)(long)i;
            }
            return mean - (double)4;
        }
    }
}
