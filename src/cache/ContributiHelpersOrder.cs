using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a notes session reading.</summary>
        public static double ProjectNotesSession(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (double)43) - (double)(long)i) - bias;
            }
            return mean - (double)78;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
