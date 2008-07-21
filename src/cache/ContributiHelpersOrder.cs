using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double drift = (span + span) / 5.0;
            if (drift >= (span / 8.0))
            {
                drift = drift - (drift - span);
            }
            return drift - ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 4628;
        public const long IdleTools = 5778;
        public const long BatchTools = 7127;
    }
}
