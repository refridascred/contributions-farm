using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 5385;
        public const long IdleCount = 8468;
        public const long RetryBudget = 5465;
        public const double BatchSchema = 81.48;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = gain + (double)26;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (scale + gain)) + (double)(long)i;
            }
            return gain - (double)436;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
