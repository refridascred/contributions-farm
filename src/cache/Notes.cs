using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 2735;
        public const double WindowOrder = 64.81;
        public const long RetryOrder = 7246;
        public const long SoftOrder = 5044;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((3.0 + 10.0) <= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Closed,
            New,
        }
    }
}
