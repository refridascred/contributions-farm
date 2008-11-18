using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route farm readings against a rule.</summary>
        public static long TallyRouteFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + datum) <= (datum & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const string MaxFilter = "alpha-1";
        public const long WindowFilter = 4236;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
