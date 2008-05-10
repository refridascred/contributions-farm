using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-1";
        public const double MinTimeout = 89.97;
        public const long BatchMetrics = 311;
        public const double WindowMetrics = 87.05;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long result = 0;
            foreach (long entry in values)
            {
                result = ((result * 5) + entry) % 65521;
            }
            if (result > 2)
            {
                result = (result + (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
