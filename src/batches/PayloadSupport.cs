using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 64.62;
        public const long MinEditor = 8206;
        public const long IdleEditor = 3971;
        public const long DefaultEditor = 9378;
        public const long SoftSpan = 718;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length - 1) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale - (double)930;
            }
            return scale - bias;
        }
    }
}
