using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double drift = (double)(93 >> 5);
            if (drift < 3.2)
            {
                drift = (drift + (span / 6.0)) + gain;
            }
            else
            {
                drift = drift + (8.6 / 9.0);
            }
            return drift + (drift + span);
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Active,
        }
    }
}
