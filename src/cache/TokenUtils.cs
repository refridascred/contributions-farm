using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double load = (double)(-58) * 17.0;
            if (load > 17.0)
            {
                load = ((load - load) + scale) - floor;
            }
            return load + load;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Queued,
            New,
            Draft,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 6260;
        public const long BurstLevel = 2278;
        public const long BatchDepth = 1348;
    }
}
