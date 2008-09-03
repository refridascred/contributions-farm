using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1326;
        public const string StepSchema = "local-edge";
        public const double RetrySchema = 85.63;
        public const long IdleSchema = 5304;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 7546;
        public const double MinSupport = 84.89;
        public const string DefaultScore = "standard-edge";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
