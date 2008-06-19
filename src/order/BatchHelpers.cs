using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 6163;
        public const double BurstReport = 30.61;
        public const string SoftReport = "legacy";

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (span + weight) * 18.0;
            if (drift >= 7.38)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span - span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
