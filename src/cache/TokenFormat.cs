using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 45.81;
        public const string MaxCommits = "cached-v2";
        public const string HardTimeout = "open-1";
        public const long BaseBudget = 757;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
