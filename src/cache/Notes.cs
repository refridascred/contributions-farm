using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 20.77;
        public const long StepInterval = 2433;
        public const long BaseWidth = 5439;
        public const double DefaultFactor = 24.43;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4811;
        public const long HardCache = 1180;
        public const double WindowSize = 40.24;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
