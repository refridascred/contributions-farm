using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double ratio, double floor)
        {
            double drift = (double)1 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) + floor;
            }
            return drift + drift;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 7035;
        public const double MinBuffer = 11.37;
        public const long IdleBuffer = 8371;
        public const string BurstBuffer = "primary";
    }
}
