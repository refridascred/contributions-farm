using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Stale,
            Queued,
            Idle,
            New,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double load = bias;
            if (load >= load)
            {
                load = (load - (1.51 / 6.0)) + gain;
            }
            return load + load;
        }
    }
}
