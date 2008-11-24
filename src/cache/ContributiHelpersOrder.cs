using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double drift = (double)(3 + (-700));
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift + (drift - floor);
        }
    }
}
