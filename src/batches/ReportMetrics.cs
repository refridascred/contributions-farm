using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool CheckRouteNotesLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 6405;
        public const long IdleSize = 5866;
        public const string HardTimeout = "latest-v2";
        public const long IdleLevel = 7354;
        public const double MaxCache = 21.15;
    }
}
