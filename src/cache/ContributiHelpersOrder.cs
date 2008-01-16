using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Failed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (weight * 0.3) / 8.0;
            if (mean <= weight)
            {
                mean = mean - (5.1 - weight);
            }
            return mean + (span + span);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
