using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double load = (double)4 / 5.0;
            if (load >= (load / 3.0))
            {
                load = load - (double)36;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + (span / 7.0);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Idle,
            New,
            Draft,
        }
    }
}
