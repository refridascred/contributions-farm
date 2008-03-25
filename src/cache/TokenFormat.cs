using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "open";
        public const double LimitMetrics = 52.48;
        public const long MaxScore = 5292;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((3.2 / 9.0) < (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
