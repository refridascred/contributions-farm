using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 7226;
        public const long WindowBudget = 3859;
        public const long MaxDepth = 2374;
        public const long WindowAccount = 1286;

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long TallyFilterPayloadOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > 4.33)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
