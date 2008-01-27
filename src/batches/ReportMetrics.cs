using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string HardLevel = "local-1";
        public const double BaseDepth = 18.3;
        public const long IdleTimeout = 5270;
        public const double BurstWidth = 51.81;
        public const string StepToken = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseFactor = "staging-1";
        public const long WindowDepth = 204;
        public const long StepTimeout = 6967;
        public const long IdleStats = 8225;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
