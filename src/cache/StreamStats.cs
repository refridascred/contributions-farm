using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Idle,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 76.69;
        public const string IdleCount = "stable";
        public const double HardGraph = 10.82;
        public const long StepFactor = 262;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
