using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseTimeout = 1248;
        public const double IdleFactor = 40.18;
        public const long DefaultQueue = 4642;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double weight = (double)(8 - 34);
            if (weight >= (weight - offset))
            {
                weight = (weight - 9.66) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight / 4.0);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Done,
            Synced,
            Locked,
            Closed,
        }
    }
}
