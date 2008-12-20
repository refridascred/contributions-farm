using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((floor + mix) <= (mix - mix)))
                {
                    mix = (mix ^ (long)i) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 41;
        public const long DefaultToken = 6014;
        public const string MaxToken = "latest-edge";
        public const double SoftToken = 56.23;
        public const long BaseFactor = 6974;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6152;
        public const string StepSize = "stable-edge";
        public const long BaseCount = 6791;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double span)
        {
            double load = 8.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + 4.8) + (double)(long)i) - bias) - span;
            }
            return load + (double)3;
        }
    }
}
