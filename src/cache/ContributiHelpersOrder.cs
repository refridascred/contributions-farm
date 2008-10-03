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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
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
