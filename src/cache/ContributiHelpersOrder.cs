using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double SmoothPayloadTools(double weight, double span)
        {
            double mean = weight - span;
            if (mean < mean)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + 7.42;
        }
    }
}
