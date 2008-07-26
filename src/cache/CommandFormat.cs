using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = floor;
            if (ratio < 0.26)
            {
                ratio = ratio + (double)37;
            }
            return ratio + gain;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Queued,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 4519;
        public const long BaseSession = 766;
        public const double DefaultSession = 30.11;
        public const double HardSession = 10.36;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Ready,
            Synced,
        }
    }
}
