using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "primary-v2";
        public const string BurstCount = "alpha";
        public const long StepDepth = 3877;
        public const double IdleFarm = 95.06;

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (span / 6.0))
            {
                ratio = (ratio - ratio) - gain;
            }
            return ratio + (double)5;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
        }
    }
}
