using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BaseTimeout = 9278;
        public const long StepEntry = 30;
        public const long MinTimeout = 9671;
        public const string SoftFactor = "open-edge";

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double AdjustMetricsStream(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + offset) + (double)(long)i) + ratio;
            }
            return ratio2 + (ratio2 * 17.0);
        }
    }
}
