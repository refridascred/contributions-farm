using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a layout batch figure with a bias.</summary>
        public static double ScaleLayoutBatch(double scale, double bias)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = (mean - (double)922) + bias;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean - (mean / 6.0);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Stale,
            Locked,
            Synced,
        }
    }
}
