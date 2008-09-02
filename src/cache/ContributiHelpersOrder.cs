using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a payload window reading.</summary>
        public static double ScalePayloadWindow(double gain, double offset)
        {
            double scale = offset / 8.0;
            if (scale < (double)208)
            {
                scale = (scale + (double)7) + gain;
            }
            else
            {
                scale = scale + (scale * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)13) + (double)(long)i;
            }
            return scale - (offset / 4.0);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Paused,
            Idle,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
