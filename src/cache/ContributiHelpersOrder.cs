using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double scale = bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias) + (double)(long)i) + offset;
            }
            return scale + bias;
        }
    }
}
