using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double floor)
        {
            double gain = (double)(48 << 1);
            if (gain > ratio)
            {
                gain = gain - (ratio + floor);
            }
            return gain + floor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinTimeout = 12.63;
        public const double SoftFactor = 67.86;
        public const long BaseFarm = 3602;
    }
}
