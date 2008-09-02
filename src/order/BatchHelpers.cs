using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double gain2 = (gain * 1.7) / 4.0;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain2 + gain)) + (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 3933;
        public const long StepSize = 3655;
        public const string HardContext = "latest-edge";
    }
}
