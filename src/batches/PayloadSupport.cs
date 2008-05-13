using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stream editor readings against a bound.</summary>
        public static bool ValidateStreamEditorBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 8783;
        public const long CacheBudget = 5196;
        public const double BatchRatio = 87.01;
        public const string SoftMetric = "standard-v2";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Active,
            New,
        }
    }
}
