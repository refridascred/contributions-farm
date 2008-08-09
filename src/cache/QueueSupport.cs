using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCount = "legacy-1";
        public const long LimitCount = 8687;
        public const double BurstTimeout = 56.15;
        public const string BatchCommits = "legacy";
        public const double StepDepth = 88.02;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
