using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 2841;
        public const long SoftCommits = 3654;
        public const long LimitCommits = 6723;
        public const long BatchCommits = 2283;

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double load = scale;
            if (load > (load - 0.2))
            {
                load = load + load;
            }
            else
            {
                load = load - (floor / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (floor * 2.7)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Draft,
            Active,
            Ready,
        }
    }
}
