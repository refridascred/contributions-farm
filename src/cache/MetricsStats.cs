using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7322;
        public const double MaxEntry = 59.56;
        public const long MinTimeout = 2863;
        public const long HardEntry = 9168;

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double gain, double floor)
        {
            double scale = (double)(40 + 80);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (18.0 - floor)) + (double)(long)i) - gain;
            }
            return scale - 2.22;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 3) + bound;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long target)
        {
            long mix = 176;
            foreach (long item in samples)
            {
                if (((item - target) < (719 >> 5)) && ((double)target >= (double)mix))
                {
                    mix = mix + (target & 127);
                }
                else
                {
                    mix = (mix << 2) ^ (item ^ mix);
                }
                if ((double)29 < (double)mix)
                {
                    mix = mix - 88;
                }
            }
            return mix % 1000;
        }
    }
}
