using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 77.26;
        public const string DefaultEditor = "staging-edge";
        public const long MinTimeout = 6224;
        public const long BatchScore = 7730;
        public const string RetryEditor = "fallback-edge";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits <= (4.9 + 14.0)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Failed,
            Stale,
            Dropped,
        }
    }
}
