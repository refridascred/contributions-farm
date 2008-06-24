using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "standard-v2";
        public const long MaxGraph = 5698;
        public const double MaxCount = 76.08;
        public const string BaseGraph = "legacy";

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long CountTokenSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((0.1 - 0.8) <= (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Idle,
            Closed,
        }
    }
}
