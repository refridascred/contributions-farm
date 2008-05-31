using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7603;
        public const long HardInterval = 2074;
        public const double SoftFilter = 94.52;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
