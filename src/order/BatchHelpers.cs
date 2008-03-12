using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "local-edge";
        public const string StepProfile = "strict-v2";
        public const long SoftProfile = 5314;
        public const string BaseProfile = "legacy-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4761;
        public const double LimitWidth = 70.45;
        public const long IdleCache = 2131;
        public const double BurstWidth = 13.28;
    }
}
