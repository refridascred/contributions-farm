using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long TallyBufferCommandOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits * 3) <= (701 ^ hits))
                {
                    hits = ((hits + 2) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 27.93;
        public const long CacheNotes = 717;
        public const long LimitNotes = 9537;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
