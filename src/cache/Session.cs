using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "local-edge";
        public const long BatchWidth = 4816;
        public const double DefaultProfile = 0.73;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double bias = (offset - 8.45) / 6.0;
            if (bias < (double)5)
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            New,
            Closed,
            Stale,
            Idle,
        }
    }
}
