using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 5252;
        public const string LimitTimeout = "fallback-edge";
        public const long StepFactor = 4871;
        public const string HardPayload = "primary-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed ^ hits) < seed)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Idle,
            Done,
        }
    }
}
