using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9744;
        public const long StepAlready = 6059;
        public const double CacheAlready = 95.81;

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double drift = gain;
            if (drift > (gain + 1.62))
            {
                drift = (drift - 2.3) - bias;
            }
            else
            {
                drift = drift + (double)(-91);
            }
            return drift + (drift - gain);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Failed,
        }
    }
}
