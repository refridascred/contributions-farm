using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long limit)
        {
            long offset = target ^ limit;
            if ((target + limit) >= (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((800 + target) < offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 6) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
